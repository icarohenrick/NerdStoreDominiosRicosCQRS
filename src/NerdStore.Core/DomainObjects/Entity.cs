using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;

namespace NerdStore.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        private List<Event> _notificacoes;
        public IReadOnlyCollection<Event> Notificacoes => _notificacoes?.AsReadOnly();

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public void RemoverEvento(Event eventItem) => _notificacoes?.Remove(eventItem);
        public void LimparEventos() => _notificacoes?.Clear();
        public void AdicionarEvento(Event evento)
        {
            _notificacoes = _notificacoes ?? new List<Event>();
            _notificacoes.Add(evento);
        }

        public override bool Equals(object obj)
        {
            var comparteTo = obj as Entity;

            if (ReferenceEquals(this, comparteTo)) return true;
            if (ReferenceEquals(null, comparteTo)) return false;

            return Id.Equals(comparteTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b) => !(a == b);

        public override int GetHashCode() => (GetType().GetHashCode() * 666) + Id.GetHashCode();

        public override string ToString() => $"{GetType().Name} [Id={Id}]";

        public virtual bool EhValido() => throw new NotImplementedException();
    }
}
