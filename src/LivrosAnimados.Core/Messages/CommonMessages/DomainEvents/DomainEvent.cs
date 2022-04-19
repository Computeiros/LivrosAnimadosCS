using MediatR;
using System;

namespace LivrosAnimados.Core.Messages.CommonMessages.DomainEvents
{
    public abstract class DomainEvent : Message, INotification
    {
        protected DomainEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
            Timestamp = DateTime.Now;
        }

        public DateTime Timestamp { get; private set; }
    }
}
