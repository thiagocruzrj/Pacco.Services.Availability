using System;
using System.Linq;
using Pacco.Services.Availability.Core.Entities;
using Pacco.Services.Availability.Core.ValueObjects;

namespace Pacco.Services.Availability.Infrastructure.Mongo.Documents
{
    internal static class Extensions
    {
        public static Resource AsEntity(this ResourceDocument document) =>
            new Resource(document.Id, document.Tags, document.Reservations?
                .Select(r => new Reservation(r.TimeStamp.AsDateTime(), r.Priority)));

        public static int AsDaysSinceEpoch(this DateTime dateTime) =>
            (dateTime - new DateTime()).Days;

        public static DateTime AsDateTime(this int daysSinceEpoch) =>
            new DateTime().AddDays(daysSinceEpoch);
    }
}