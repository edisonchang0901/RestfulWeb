using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestfulWeb.Domain.Profiles;
using RestfulWeb.infrastructure.Models;

namespace RestfulWeb.infrastructure.DI
{
    public static partial class DependencyInjection
    {
        public static IServiceCollection AddDbAccountMainContext(this IServiceCollection services) 
        {
            services.AddPooledDbContextFactory<AccountMainContext>(options =>
            {
                options.UseSqlServer(ProfileInstance.RDS_ConnectionStrings, sqlServerOptionsAction => sqlServerOptionsAction
                       .CommandTimeout(600))
                       .EnableThreadSafetyChecks(true);
            }, 100);
            return services;
        }

        public static bool CheckAccountMainConnect(this IApplicationBuilder app) 
        {
            IDbContextFactory<AccountMainContext> factory = app.ApplicationServices.GetRequiredService<IDbContextFactory<AccountMainContext>>();
            AccountMainContext accountMainContext = factory.CreateDbContext();
            return accountMainContext.Database.CanConnect();
        }
    }
}
