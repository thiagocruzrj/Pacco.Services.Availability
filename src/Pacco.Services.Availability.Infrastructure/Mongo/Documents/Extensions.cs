using System;
using System.Linq;
using Pacco.Services.Availability.Application.DTO;
using Pacco.Services.Availability.Core.Entities;
using Pacco.Services.Availability.Core.ValueObjects;

namespace Pacco.Services.Availability.Infrastructure.Mongo.Documents
{
    internal static class Extensions
    {
        public static Resource AsEntity(this ResourceDocument document) =>
            new Resource(document.Id, document.Tags, document.Reservations?
                .Select(r => new Reservation(r.TimeStamp.AsDateTime(), r.Priority)));

        public static ResourceDocument AddDocument(this Resource entity) =>
            new ResourceDocument
            {
                Id = entity.Id,
                Version = entity.Version,
                Tags = entity.Tags,
                Reservations = entity.Reservations.Select(r => new ReservationDocument
                {
                    TimeStamp = r.DateTime.AsDaysSinceEpoch(),
                    Priority = r.Priority
                })
            };

        public static ResourceDto AsDto(this ResourceDocument document) =>
            new ResourceDto
            {
                Id = document.Id,
                Tags = document.Tags ?? Enumerable.Empty<string>(),
                Reservations = document?.Reservations.Select(r =>
                    new ReservationDto
                    {
                        Priority = r.Priority,
                        DateTime = r.TimeStamp.AsDateTime()
                    }) ?? Enumerable.Empty<ReservationDto>()
            };

        public static int AsDaysSinceEpoch(this DateTime dateTime) =>
            (dateTime - new DateTime()).Days;

        public static DateTime AsDateTime(this int daysSinceEpoch) =>
            new DateTime().AddDays(daysSinceEpoch);
    }
}