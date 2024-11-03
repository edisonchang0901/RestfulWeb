using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestfulWeb.Domain.Profiles;
using RestfulWeb.infrastructure.Models;
using Serilog;

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

        public static void CheckAccountMainConnect(this IApplicationBuilder app)
        {
            IDbContextFactory<AccountMainContext> factory = app.ApplicationServices.GetRequiredService<IDbContextFactory<AccountMainContext>>();
            AccountMainContext accountMainContext = factory.CreateDbContext();
            Log.Logger.Information($"{nameof(AccountMainContext)}連線{(accountMainContext.Database.CanConnect() ? "成功" : "失敗")}");
        }
    }
}
