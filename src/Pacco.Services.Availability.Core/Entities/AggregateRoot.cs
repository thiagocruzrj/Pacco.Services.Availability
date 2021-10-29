using System.Collections.Generic;
using Pacco.Services.Availability.Core.Events;

namespace Pacco.Services.Availability.Core.Entities
{
    public abstract class AggregateRoot
    {
        private readonly List<IDomainEvent> _events = new List<IDomainEvent>();
        public AggregateId Id { get; protected set; }
        public int Version { get; protected set; }
        public IEnumerable<IDomainEvent> Events => _events;

        protected void AddEvent(IDomainEvent @event)
        {

        }
    }
}