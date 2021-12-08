using System;
using System.Collections.Concurrent;
using System.Net;
using Convey;
using Convey.WebApi.Exceptions;
using Pacco.Services.Availability.Application.Commands.Handlers;
using Pacco.Services.Availability.Core.Exceptions;

namespace Pacco.Services.Availability.Infrastructure.Exceptions
{
    internal sealed class ExceptionToResponseMapper : IExceptionToResponseMapper
    {
        private static readonly ConcurrentDictionary<Type, string> Codes = new ConcurrentDictionary<Type, string>();
        public ExceptionResponse Map(Exception exception) =>
            exception switch
            {
                DomainException ex => new ExceptionResponse(new {code = GetCode(ex), reason = ex.Message}, 
                    HttpStatusCode.BadRequest),
                AppException ex => new ExceptionResponse(new {code = GetCode(ex), reason = ex.Message}, 
                    HttpStatusCode.BadRequest),
                _ => new ExceptionResponse(new {code = "error", reason = "There was an error."}, 
                    HttpStatusCode.InternalServerError)
            };

        private static string GetCode(Exception exception)
        {
            var type = exception.GetType();
            if(Codes.TryGetValue(type, out var code))
            {
                return code;
            }

            var exceptionCode = exception switch
            {
                DomainException ex when !string.IsNullOrWhiteSpace(ex.Code) => ex.Code,
                AppException ex when !string.IsNullOrWhiteSpace(ex.Code) => ex.Code,
                _ => type.Name.Underscore().Replace("_exception", string.Empty)
            };

            Codes.TryAdd(type, exceptionCode);

            return exceptionCode;
        }
    }
}