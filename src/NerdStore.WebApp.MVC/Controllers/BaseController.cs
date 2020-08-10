using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NerdStore.WebApp.MVC.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly DomainNotificationHandler _notifications;
        private readonly IMediatRHandler _mediatRHandler;

        protected Guid ClienteId = Guid.Parse("d8645797-bfd6-4ac6-9c9c-c45e7f51cf8c");

        protected BaseController(INotificationHandler<DomainNotification> notifications, IMediatRHandler mediatRHandler)
        {
            _notifications = (DomainNotificationHandler)notifications;
            _mediatRHandler = mediatRHandler;
        }

        protected bool OperacaoValida() => !_notifications.TemNotificacao();

        protected IEnumerable<string> ObterMensagemErro() => _notifications.ObterNotificacoes().Select(n => n.Value).ToList();

        protected void NotificarErro(string codigo, string mensagem) => _mediatRHandler.PublicarNotificacao(new DomainNotification(codigo, mensagem));
    }
}
