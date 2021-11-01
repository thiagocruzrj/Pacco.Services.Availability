using System;

namespace Pacco.Services.Availability.Infrastructure.Mongo.Documents
{
    internal abstract class ReservationDocument
    {
        public DateTime DateTime { get; set; }
        public int Priority { get; set; }
    }
}