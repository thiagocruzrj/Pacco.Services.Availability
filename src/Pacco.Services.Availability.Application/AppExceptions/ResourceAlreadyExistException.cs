using System;

namespace Pacco.Services.Availability.Application.Commands.Handlers
{
    public class ResourceAlreadyExistException : AppException
    {

        public ResourceAlreadyExistException(string message) : base(message) { }
    }
}