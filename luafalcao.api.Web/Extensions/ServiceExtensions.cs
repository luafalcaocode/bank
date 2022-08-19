using luafalcao.api.Domain.Facade;
using luafalcao.api.Persistence.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace luafalcao.api.Web.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });

        public static void ConfigureMapper(this IServiceCollection services) =>
            services.AddAutoMapper(typeof(Startup));

        public static void ConfigureRazor(this IServiceCollection services) =>
           services.AddRazorPages(options =>
           {

           });

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo { Title = "ASP .NET Core API - Bank", Version = "v1" });
            });
        }       
      

        public static void ConfigureFacades(this IServiceCollection services)
        {
            services.AddScoped<ICreditoFacade, CreditoFacade>();
        }

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("SqlServerConnection"), b => 
             b.MigrationsAssembly("luafalcao.api.Persistence")));
    }
}
