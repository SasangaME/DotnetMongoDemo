using MongoDemo.Db.Config;

namespace MongoDemo.API.Config
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services) => services
                .AddRepositories();
    }
}
