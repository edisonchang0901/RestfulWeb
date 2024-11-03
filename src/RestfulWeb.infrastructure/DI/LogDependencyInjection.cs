using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;
using Serilog.Formatting.Json;
using Serilog.Hosting;
using Serilog.Sinks.File;
namespace RestfulWeb.infrastructure.DI
{
    public static partial class LogDependencyInjection
    {
        public static IServiceCollection AddSerilog(this IServiceCollection services) 
        {
            var template = "{Timestamp:HH:mm:ss} [{Level:u3}] {Message}{NewLine}{Exception}";
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .WriteTo.File(

                    path: "./logs/log-.log", 
                    outputTemplate: template
                )
                .CreateLogger();
            services.AddSerilog(Log.Logger);
            return services;
        }
    }
}
