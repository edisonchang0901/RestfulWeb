using Microsoft.Extensions.DependencyInjection;
using RestfulWeb.Domain.Interfaces;
using RestfulWeb.infrastructure.Repository;

namespace RestfulWeb.infrastructure.DI
{
    public static partial class  RepositoryDependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services) 
        {
            services.AddSingleton<IUserRepository, DapperRepository>();
            services.AddSingleton<IUserRepository, EFRepository>();
            return services;
        }
    }
    
 
}
