using System;
using System.Diagnostics.CodeAnalysis;
using Pacco.Services.Availability.Core.Exceptions;

namespace Pacco.Services.Availability.Core.Entities
{
    public class AggregateId : IEquatable<AggregateId>
    {
        public Guid Value { get; }

        public AggregateId() : this(Guid.NewGuid()) { }

        public AggregateId(Guid value)
        {
            if(value == Guid.Empty)
            {
                throw new InvalidAggregateIdException(value);
            }

            Value = value;
        }

        public bool Equals([AllowNull] AggregateId other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value.Equals(other.Value);
        }

        public override bool Equals([AllowNull] object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if(obj.GetType() != this.GetType()) return false;
            return Value.Equals((AggregateId) obj);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}