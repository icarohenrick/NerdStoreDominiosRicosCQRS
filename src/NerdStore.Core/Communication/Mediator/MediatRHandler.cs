using MediatR;
using NerdStore.Core.Data.EventSourcing;
using NerdStore.Core.Messages;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using NerdStore.Core.Messages.DomainEvents;
using System.Threading.Tasks;

namespace NerdStore.Core.Communication.Mediator
{
    public class MediatRHandler : IMediatRHandler
    {
        private readonly IMediator _mediator;
        private readonly IEventSourcingRepository _eventSourcingRepository;

        public MediatRHandler(IMediator mediator, IEventSourcingRepository eventSourcingRepository)
        { 
            _mediator = mediator;
            _eventSourcingRepository = eventSourcingRepository;
        }

        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _mediator.Publish(evento);
            _eventSourcingRepository.SalvarEvento(evento);
        }

        public async Task<bool> EnviarComando<T>(T comando) where T : Command => await _mediator.Send(comando);

        public async Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification => await _mediator.Publish(notificacao);

        public async Task PublicarDomainEvent<T>(T notificacao) where T : DomainEvent => await _mediator.Publish(notificacao);
    }
}
