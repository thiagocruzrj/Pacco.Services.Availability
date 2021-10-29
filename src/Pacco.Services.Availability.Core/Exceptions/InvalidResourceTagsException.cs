namespace Pacco.Services.Availability.Core.Exceptions
{
    internal class InvalidResourceTagsException : DomainException
    {
        public InvalidResourceTagsException() : base($"Invalid tags for the resource ID.") {}
    }
}