using Microsoft.OpenApi.Models;
using PedraPapelTesoura.Application.ApplicationServices;
using PedraPapelTesoura.Application.Interface;

namespace PedraPapelTesoura.Api
{
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IPedraPapelTesouraApplication, PedraPapelTesouraApplication>();
            services.AddHealthChecks();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "PedraPapelTesoura",
                    Description = "PedraPapelTesoura."
                });

                var filePath = Path.Combine(AppContext.BaseDirectory, "PedraPapelTesoura.xml");
                c.IncludeXmlComments(filePath);
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PedraPapelTesoura"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("/health");
                endpoints.MapControllers();
            });
        }
    }
}
