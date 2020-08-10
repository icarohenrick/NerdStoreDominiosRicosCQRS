using FluentValidation.Results;
using MediatR;
using System;

namespace NerdStore.Core.Messages
{
    public class Command : Message, IRequest<bool>
    {
        public Command() => TimeStamp = DateTime.Now;
        public DateTime TimeStamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }
        public virtual bool EhValido() => throw new NotImplementedException();
    }
}