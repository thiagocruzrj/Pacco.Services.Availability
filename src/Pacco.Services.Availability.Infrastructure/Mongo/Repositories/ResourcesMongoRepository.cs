using System.Threading.Tasks;
using Pacco.Services.Availability.Core.Entities;
using Pacco.Services.Availability.Core.Repositories;
using Convey.Persistence.MongoDB;
using Pacco.Services.Availability.Infrastructure.Mongo.Documents;
using System;

namespace Pacco.Services.Availability.Infrastructure.Mongo.Repositories
{
    internal sealed class ResourcesMongoRepository : IResourcesRepository
    {
        private readonly IMongoRepository<ResourceDocument, Guid> _repository;

        public ResourcesMongoRepository(IMongoRepository<ResourceDocument, Guid> repository) =>
            _repository = repository;

        public Task AddAsync(Resource resource) =>
            _repository.AddAsync(resource.AddDocument());

        public Task DeleteAsync(AggregateId id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Resource> GetAsync(AggregateId id)
        {
            var document = await _repository.GetAsync(r => r.Id == id);
            return document?.AsEntity();
        }

        public Task UpdateAsync(Resource resource)
        {
            throw new System.NotImplementedException();
        }
    }
}