using AutoMapper;
using CCiG_WebApi.Infrastructure.Persistance;
using CCiG_WebApi.Infrastructure.Repositories;
using CCiG_WebApi.Infrastructure.Repositories.Interfaces;
using CCiG_WebApi.Mappings.Schedule;
using CCiG_WebApi.Services.Schedule;
using Microsoft.EntityFrameworkCore;

namespace CCiG_WebApi
{
    public static class ServiceCollectionExtension
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddScoped<IScheduleService, ScheduleService>();

            service.AddScoped(provider => new MapperConfiguration(cfg =>
            {
                var scope = provider.CreateScope();
                cfg.AddProfile(new ScheduleMappingProfile());
            }).CreateMapper());
        }

        public static void AddInfrastructure(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<CCiG_DbContext>(options => options.UseSqlite(
                configuration.GetConnectionString("localdb")));

            service.AddScoped<IScheduleRepository, ScheduleRepository>();
        }
    }
}
