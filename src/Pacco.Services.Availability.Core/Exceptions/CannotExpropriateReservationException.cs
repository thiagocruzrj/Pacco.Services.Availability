using System;

namespace Pacco.Services.Availability.Core.Exceptions
{
    public class CannotExpropriateReservationException : DomainException
    {
        public Guid ResourceId { get; }
        public DateTime DateTime { get; }

        public CannotExpropriateReservationException(Guid resourceId, DateTime dateTime) : base($"Cannot expropriate the resource with ID: '{resourceId} reservation at: {dateTime.Date}'")
        {
            ResourceId = resourceId;
            DateTime = dateTime;
        }
    }
}