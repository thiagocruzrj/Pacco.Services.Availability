namespace Pacco.Services.Availability.Core.Entities
{
    public class AggregateRoot
    {
        public AggregateId Id { get; protected set; }
        public int Version { get; protected set; }
    }
}