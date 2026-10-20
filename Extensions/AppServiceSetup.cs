using Microsoft.EntityFrameworkCore;
using VacationPlanner.Data;
namespace VacationPlanner.Extensions
{
    public static class AppServiceSetup
    {
        public static IServiceCollection AddAppServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            service.AddEndpointsApiExplorer();
            service.AddSwaggerGen();

            return service;
        }
        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            return app;
        }
    }
}
