using System.Threading.Tasks;
using Pacco.Services.Availability.Core.Entities;
using Pacco.Services.Availability.Core.Repositories;
using Convey.Persistence.MongoDB;

namespace Pacco.Services.Availability.Infrastructure.Mongo.Repositories
{
    internal sealed class ResourcesMongoRepository : IResourcesRepository
    {
        public ResourcesMongoRepository(IMongoRepository<Resource> repo)
        {
            
        }
        public Task AddAsync(Resource resource)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(AggregateId id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Resource> GetAsync(AggregateId id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Resource resource)
        {
            throw new System.NotImplementedException();
        }
    }
}