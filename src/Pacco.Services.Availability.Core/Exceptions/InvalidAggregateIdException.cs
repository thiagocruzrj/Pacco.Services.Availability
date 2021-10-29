using System;

namespace Pacco.Services.Availability.Core.Exceptions
{
    public class InvalidAggregateIdException : DomainException
    {
        protected InvalidAggregateIdException(Guid id ) : base($"Invalid aggregate ID: '{id}.") { }
    }
}