using Microsoft.Extensions.DependencyInjection;
using Track4GoApplication.Interface;
using Track4GoApplication.Mappings;
using Track4GoApplication.Services;
using Track4GoDomain.Interfaces;
using Track4GoPersistence.Context;
using Track4GoPersistence.Repository;

namespace Track4GoIoC
{
    public static class Track4GoDependencyContainer
    {
        public static void  RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<UserContext>();
        }
        
        public static void RegisterServicesApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingConfiguration));
            MappingConfiguration.RegisterMappings();
        }
    }
}
