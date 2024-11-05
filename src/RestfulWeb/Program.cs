using RestfulWeb.infrastructure.DI;
using RestfulWeb.DI;
using RestfulWeb.Application.DI;
using Serilog;

namespace RestfulWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var builder = WebApplication.CreateBuilder(args);
                builder.Services.AddSerilog();
                // Add services to the container.
                builder.Services.AddControllers();
                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddProfilesBind(builder.Configuration);
                builder.Services.AddDbAccountMainContext();
                builder.Services.AddDapperDbFactoryc();
                builder.Services.AddAppService();
                builder.Services.AddAutoMapperSetup();
                builder.Services.AddRepository();
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();
                builder.Services.AddApiVersioning();

                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();

                app.UseAuthorization();

                app.CheckAccountMainConnect();

                app.MapControllers();

                app.Run();
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"{ex}");
            }   
        }
    }
}
