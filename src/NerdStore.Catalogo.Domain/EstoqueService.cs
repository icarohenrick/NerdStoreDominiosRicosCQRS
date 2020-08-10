using Microsoft.VisualBasic;
using NerdStore.Catalogo.Domain.Events;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.DomainObjects.DTO;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain
{
    public class EstoqueService : IEstoqueService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMediatRHandler _mediatRHandler;

        public EstoqueService(  IProdutoRepository produtoRepository, 
                                IMediatRHandler mediatRHandler)
        {
            _produtoRepository = produtoRepository;
            _mediatRHandler = mediatRHandler;
        }

        public async Task<bool> DebitarEstoque(Guid produtoId, int quantidade)
        {
            if (!await DebitarItemEstoque(produtoId, quantidade)) return false;

            return await _produtoRepository.UnitOfWork.Commit();
        }

        public async Task<bool> DebitarListaProdutsoPedido(ListaProdutosPedido lista)
        {
            foreach (var item in lista.Itens)
                if (!await DebitarItemEstoque(item.Id, item.Quantidade)) return false;

            return await _produtoRepository.UnitOfWork.Commit();
        }

        private async Task<bool> DebitarItemEstoque(Guid produtoId, int quantidade)
        {
            var produto = await _produtoRepository.ObterPorId(produtoId);

            if (produto == null) return false;

            if (!produto.PossuiEstoque(quantidade))
            {
                await _mediatRHandler.PublicarNotificacao(new DomainNotification("Estoque", $"Produto = {produto.Nome} sem estoque"));
                return false;
            }

            produto.DebitarEstoque(quantidade);

            if(produto.QuantidadeEstoque < 10)
                await _mediatRHandler.PublicarDomainEvent(new ProdutoAbaixoEstoqueEvent(produtoId, produto.QuantidadeEstoque));

            _produtoRepository.Atualizar(produto);
            return true;
        }

        public async Task<bool> ReporListaProdutosPedido(ListaProdutosPedido lista)
        {
            foreach (var item in lista.Itens)
                await ReporItemEstoque(item.Id, item.Quantidade);

            return await _produtoRepository.UnitOfWork.Commit();
        }

        public async Task<bool> ReporEstoque(Guid produtoId, int quantidade)
        {
            var suceso = await ReporItemEstoque(produtoId, quantidade);

            if (!suceso) return false;

            return await _produtoRepository.UnitOfWork.Commit();
        }

        private async Task<bool> ReporItemEstoque(Guid produtoId, int quantidade)
        {
            var produto = await _produtoRepository.ObterPorId(produtoId);

            if (produto == null) return false;
            produto.ReporEstoque(quantidade);

            _produtoRepository.Atualizar(produto);

            return true;
        }

        public void Dispose() => _produtoRepository.Dispose();
    }
}
