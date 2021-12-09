using System.Threading.Tasks;
using Convey.CQRS.Commands;
using Pacco.Services.Availability.Core.Repositories;
using Pacco.Services.Availability.Core.ValueObjects;

namespace Pacco.Services.Availability.Application.Commands.Handlers
{
    public class ReserveResourceHandler : ICommandHandler<ReserverResoucer>
    {
        private readonly IResourcesRepository _resourcesRepository;
        public ReserveResourceHandler(IResourcesRepository resourcesRepository)
        {
            _resourcesRepository = resourcesRepository;
        }

        public async Task HandleAsync(ReserverResoucer command)
        {
            var resource = await _resourcesRepository.GetAsync(command.ResourceId);

            if(resource is null)
            {
                throw new ResourceNotFoundException(command.ResourceId);
            }

            var reservation = new Reservation(command.DateTime, command.Priority);
            resource.AddReservation(reservation);
            
            await _resourcesRepository.UpdateAsync(resource);
        }
    }
}