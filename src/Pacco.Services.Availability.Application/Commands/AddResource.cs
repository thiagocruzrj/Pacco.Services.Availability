using System;
using System.Collections.Generic;
using Convey.CQRS.Commands;

namespace Pacco.Services.Availability.Application.Commands
{
    public class AddResource : ICommand
    {
        public Guid Id { get; }
        public IEnumerable<string> Tags { get; }

        public AddResource(Guid id, IEnumerable<string> tags)
        {
            Id = id;
            Tags = tags;
        }
    }
}