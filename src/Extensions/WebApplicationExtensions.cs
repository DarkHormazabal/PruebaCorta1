using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCorta1.src.Extensions
{
    public static class WebApplicationExtensions
    {
        public static void ConfigureApp(this WebApplication app)
        {
            app.MapControllers();
            app.UseCors("AllowAll");
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { _ = endpoints.MapControllers(); });

            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;

            try
            {
                //var context = services.GetRequiredService<DataContext>();
                //context.Database.Migrate();
                //no esta creado el dataContext
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<WebApplication>>();
                logger.LogError(ex, "An error occurred during migration");
            }
        }
    }
}