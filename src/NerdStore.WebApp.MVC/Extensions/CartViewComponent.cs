using Microsoft.AspNetCore.Mvc;
using NerdStore.Vendas.Application.Queries;
using System;
using System.Threading.Tasks;

namespace NerdStore.WebApp.MVC.Extensions
{
    public class CartViewComponent : ViewComponent
    {
        private readonly IPedidoQueries _pedidoQueries;

        //TODO: Obter cliente Logado
        protected Guid ClienteId = Guid.Parse("d8645797-bfd6-4ac6-9c9c-c45e7f51cf8c");

        public CartViewComponent(IPedidoQueries pedidoQueries) => _pedidoQueries = pedidoQueries;
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var carrinho = await _pedidoQueries.ObterCarrinhoCliente(ClienteId);
            var itens = carrinho?.Items.Count ?? 0;

            return View(itens);
        }
    }
}
