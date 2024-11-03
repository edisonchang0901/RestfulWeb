using RestfulWeb.Domain.Profiles;
namespace RestfulWeb.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProfilesBind(this IServiceCollection services, IConfiguration configuration) 
        {
             ProfileInstance.RDS_ConnectionStrings = configuration.GetConnectionString(ProfileInstance.RDS_CONNECTIONSRINGS_KEY);
            return services;
        }
    }
}
