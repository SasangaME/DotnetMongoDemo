using Microsoft.Extensions.DependencyInjection;
using MongoDemo.Db.Repositories;

namespace MongoDemo.Db.Config
{
    public static class ServiceResolution
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<IPetRepository, PetRepository>();
        }
    }
}
