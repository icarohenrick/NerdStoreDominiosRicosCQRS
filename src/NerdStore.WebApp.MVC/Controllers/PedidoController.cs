using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using NerdStore.Vendas.Application.Queries;

namespace NerdStore.WebApp.MVC.Controllers
{
    public class PedidoController : BaseController
    {
        private readonly IPedidoQueries _pedidoQueries;
        public PedidoController(IPedidoQueries pedidoQueries,
            INotificationHandler<DomainNotification> notifications, 
            IMediatRHandler mediatRHandler) : base(notifications, mediatRHandler)
        {
            _pedidoQueries = pedidoQueries;
        }

        [Route("meus-pedidos")]
        public async Task<IActionResult> Index()
        {
            return View(await _pedidoQueries.ObterPedidosCliente(ClienteId));
        }
    }
}