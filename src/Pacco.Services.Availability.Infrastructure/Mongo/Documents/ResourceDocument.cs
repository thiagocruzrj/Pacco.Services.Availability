using System;
using System.Collections.Generic;

namespace Pacco.Services.Availability.Infrastructure.Mongo.Documents
{
    internal sealed class ResourceDocument
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public IEnumerable<ReservationDocument> Reservations { get; set; }
    }
}