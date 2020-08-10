using MediatR;
using System;

namespace NerdStore.Core.Messages
{
    public abstract class Event : Message, INotification
    {
        public Event() => Timestamp = DateTime.Now;

        public DateTime Timestamp { get; private set; }
    }
}