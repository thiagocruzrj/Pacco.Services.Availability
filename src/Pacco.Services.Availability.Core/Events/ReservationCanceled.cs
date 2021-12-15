using Pacco.Services.Availability.Core.Entities;
using Pacco.Services.Availability.Core.ValueObjects;

namespace Pacco.Services.Availability.Core.Events
{
    public class ReservationCanceled : IDomainEvent
    {
        public Resource Resource { get; }
        public Reservation Reservation { get; set; }

        public ReservationCanceled(Resource resource, Reservation reservation)
        {
            Resource = resource;
            Reservation = reservation;
        }
    }
}