using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.DomainObjects.DTO;
using NerdStore.Core.Messages.CommonMessages.IntegrationEvents;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using System.Threading.Tasks;

namespace NerdStore.Pagamentos.Business
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IPagamentoCartaoCrediteoFacade _pagamentoCartaoCrediteoFacade;
        private readonly IPagamentoRepository _pagamentoRepository;
        private readonly IMediatRHandler _mediatRHandler;

        public PagamentoService(
            IPagamentoCartaoCrediteoFacade pagamentoCartaoCrediteoFacade,
            IPagamentoRepository pagamentoRepository,
            IMediatRHandler mediatRHandler)
        {
            _pagamentoCartaoCrediteoFacade = pagamentoCartaoCrediteoFacade;
            _pagamentoRepository = pagamentoRepository;
            _mediatRHandler = mediatRHandler;
        }

        public async Task<Transacao> RealizarPagamentoPedido(PagamentoPedido pagamentoPedido)
        {
            var pedido = new Pedido
            {
                Id = pagamentoPedido.PedidoId,
                Valor = pagamentoPedido.Total
            };

            var pagamento = new Pagamento
            {
                Valor = pagamentoPedido.Total,
                NomeCartao = pagamentoPedido.NomeCartao,
                NumeroCartao = pagamentoPedido.NumeroCartao,
                ExpiracaoCartao = pagamentoPedido.ExpiracaoCartao,
                CvvCartao = pagamentoPedido.CvvCartao,
                PedidoId = pagamentoPedido.PedidoId
            };

            var transacao = _pagamentoCartaoCrediteoFacade.RealizarPagamento(pedido, pagamento);

            if(transacao.StatusTransacao == StatusTransacao.Pago)
            {
                pagamento.AdicionarEvento(new PagamentoRealizadoEvent(pedido.Id, pagamentoPedido.ClienteId, transacao.PagamentoId, transacao.Id, pedido.Valor));

                _pagamentoRepository.Adicionar(pagamento);
                _pagamentoRepository.AdicionarTransacao(transacao);

                await _pagamentoRepository.UnitOfWork.Commit();

                return transacao;
            }

            await _mediatRHandler.PublicarNotificacao(new DomainNotification("Pagamento", "A Operadora do Cartão recusou o pagamento"));
            await _mediatRHandler.PublicarEvento(new PagamentoRecusadoEvent(pedido.Id, pagamentoPedido.ClienteId, transacao.PagamentoId, transacao.Id, pedido.Valor));

            return transacao;
        }
    }
}
