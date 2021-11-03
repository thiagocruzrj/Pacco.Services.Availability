using System;
using Convey;
using Convey.Persistence.MongoDB;
using Pacco.Services.Availability.Infrastructure.Mongo.Documents;

namespace Pacco.Services.Availability.Infrastructure
{
    public static class Extensions
    {
        public static IConveyBuilder AddInfrastructure(this IConveyBuilder builder)
        {
            builder.AddMongo().AddMongoRepository<ResourceDocument, Guid>("resources");

            return builder;
        }
    }
}