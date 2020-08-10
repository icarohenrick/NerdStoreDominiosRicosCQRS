using MediatR;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.Messages.CommonMessages.IntegrationEvents;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain.Events
{
    public class ProdutoEventHandler : 
        INotificationHandler<ProdutoAbaixoEstoqueEvent>,
        INotificationHandler<PedidoIniciadoEvent>,
        INotificationHandler<PedidoProcessamentoCanceladoEvent>
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IEstoqueService _estoqueSerice;
        private readonly IMediatRHandler _mediatRHandler;

        public ProdutoEventHandler(
            IProdutoRepository produtoRepository, 
            IEstoqueService estoqueSerice,
            IMediatRHandler mediatRHandler)
        {
            _estoqueSerice = estoqueSerice;
            _produtoRepository = produtoRepository;
            _mediatRHandler = mediatRHandler;
        }

        public async Task Handle(ProdutoAbaixoEstoqueEvent message, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.ObterPorId(message.AggregateId);

            //Enviar um email para requisição de mais produtos ou Tratar de alguma forma essa informação que chegou
        }

        public async Task Handle(PedidoIniciadoEvent message, CancellationToken cancellationToken)
        {
            var result = await _estoqueSerice.DebitarListaProdutsoPedido(message.ProdutoPedido);

            if (result)
                await _mediatRHandler.PublicarEvento(new PedidoEstoqueConfirmadoEvent(
                    message.PedidoId,
                    message.ClienteId,
                    message.Total,
                    message.ProdutoPedido,
                    message.NomeCartao,
                    message.NumeroCartao,
                    message.ExpiracaoCartao,
                    message.CvvCartao));
            else
                await _mediatRHandler.PublicarEvento(new PedidoEstoqueRejeitadoEvent(message.PedidoId, message.ClienteId));
        }

        public async Task Handle(PedidoProcessamentoCanceladoEvent message, CancellationToken cancellationToken)
        {
            await _estoqueSerice.ReporListaProdutosPedido(message.ProdutosPedido);
        }
    }
}
