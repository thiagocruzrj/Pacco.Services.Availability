using System;
using Convey.WebApi.Exceptions;

namespace Pacco.Services.Availability.Infrastructure.Exceptions
{
    internal sealed class ExceptionToResponseMapper : IExceptionToResponseMapper
    {
        public ExceptionResponse Map(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}