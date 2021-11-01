using System;

namespace Pacco.Services.Availability.Application.Commands.Handlers
{
    public class ResourceAlreadyExistException : AppException
    {

        public ResourceAlreadyExistException(Guid id) : base($"Resource with ID: '{id}' already exists.") { }
    }
}