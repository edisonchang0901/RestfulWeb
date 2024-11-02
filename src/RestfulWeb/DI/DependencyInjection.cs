using RestfulWeb.Domain.Profiles;
namespace RestfulWeb.DI
{
    public static class DependencyInjection
    {
        public static void AddProfilesBind(this ServiceCollection services, IConfiguration configuration) 
        {
             ProfileInstance.RDS_ConnectionStrings = configuration.GetConnectionString(ProfileInstance.RDS_CONNECTIONSRINGS_KEY);
        }
    }
}
