using System;
using System.Runtime.Serialization;

namespace Pacco.Services.Availability.Application.Commands.Handlers
{
    public abstract class AppException : Exception
    {
        public virtual string Code { get; }

        public AppException(string message) : base(message) { }
    }
}