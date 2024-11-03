using Microsoft.Extensions.DependencyInjection;
using RestfulWeb.Application.AutoMapper;
using RestfulWeb.Application.Interface;
using RestfulWeb.Application.Services;

namespace RestfulWeb.Application.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppService(this IServiceCollection services) 
        {
            services.AddSingleton<IUserAppService, UserAppService>();
            return services;
        }

        public static IServiceCollection AddAutoMapperSetup(this IServiceCollection services) 
        {
            services.AddAutoMapper(AutoMapperConfig.RegisterMappings());
            return services;
        }          
    }
}
