using System;
using Convey.CQRS.Commands;

namespace Pacco.Services.Availability.Application.Commands
{
    public class ReserverResoucer : ICommand
    {
        public Guid ResourceId { get; }
        public DateTime DateTime { get; }
        public int Priority { get; }

        public ReserverResoucer(Guid resourceId, DateTime dateTime, int priority)
        {
            ResourceId = resourceId;
            DateTime = dateTime;
            Priority = priority;

        }
    }
}