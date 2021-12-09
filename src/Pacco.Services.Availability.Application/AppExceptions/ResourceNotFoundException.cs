using System;

namespace Pacco.Services.Availability.Application.Commands.Handlers
{
    public class ResourceNotFoundException : AppException
    {
        public ResourceNotFoundException(Guid id) : base($"Resource with ID: '{id}' not found.") { }
    }
}