using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NerdStore.Core.Data.EventSourcing
{
    public interface IEventSourcingRepository
    {
        Task SalvarEvento<TEvento>(TEvento evento) where TEvento : Event;
        Task<IEnumerable<StoredEvent>> ObterEventos(Guid aggregateId);
    }
}