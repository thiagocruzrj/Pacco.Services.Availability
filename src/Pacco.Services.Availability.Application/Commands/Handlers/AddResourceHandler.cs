using System.Threading.Tasks;
using Convey.CQRS.Commands;
using Pacco.Services.Availability.Core.Repositories;

namespace Pacco.Services.Availability.Application.Commands.Handlers
{
    internal sealed class AddResourceHandler : ICommandHandler<AddResource>
    {
        private readonly IResourcesRepository _resourcesRepository;

        public AddResourceHandler(IResourcesRepository resourcesRepository)
        {
            _resourcesRepository = resourcesRepository;
        }

        public async Task HandleAsync(AddResource command)
        {
            var resource = await _resourcesRepository.GetAsync(command.ResourceId);
        }
    }
}