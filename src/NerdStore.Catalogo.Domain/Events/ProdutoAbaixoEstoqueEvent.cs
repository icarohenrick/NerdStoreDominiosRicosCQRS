using NerdStore.Core.Messages.DomainEvents;
using System;

namespace NerdStore.Catalogo.Domain.Events
{
    public class ProdutoAbaixoEstoqueEvent : DomainEvent
    {
        public ProdutoAbaixoEstoqueEvent(Guid aggregateId, int quantidadeRestante) : base(aggregateId)
            => QuantidadeRestante = quantidadeRestante;

        public int QuantidadeRestante { get; private set; }
    }
}
