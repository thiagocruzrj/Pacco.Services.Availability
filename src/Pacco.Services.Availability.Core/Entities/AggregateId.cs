using System;

namespace Pacco.Services.Availability.Core.Entities
{
    public class AggregateId
    {
        public Guid Value { get; }

        public AggregateId() : this(Guid.NewGuid())
        {
            
        }

        public AggregateId(Guid value)
        {
            if(value == Guid.Empty)
            {
                throw new ArgumentException();
            }
        }
    }
}