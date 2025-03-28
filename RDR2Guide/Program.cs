
using RDR2Guide.Extensions;
using RDR2Guide.Presentation.Extensions;

namespace RDR2Guide
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers(config =>
            {
                config.RespectBrowserAcceptHeader = true;
                config.ReturnHttpNotAcceptable = true;
            }).AddApplicationPart(typeof(RDR2Guide.Presentation.AssemblyReference).Assembly);

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.ConfigureRepositoryManager();
            builder.Services.ConfigureServiceManager();

            builder.Services.ConfigureCors();
            builder.Services.ConfigureIISIntegration();
            builder.Services.ConfigureSqlContext(builder.Configuration);

            builder.Services.ConfigureSwagger();

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddAuthentication();
            builder.Services.ConfigureIdentity();
            builder.Services.ConfigureJWT(builder.Configuration);

            builder.Services.AddScoped(typeof(UserIdParser));

            builder.Services.ConfigureFluentValidation();

            var app = builder.Build();

            app.ConfigureExceptionHandler();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors("CorsPolicy");

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
