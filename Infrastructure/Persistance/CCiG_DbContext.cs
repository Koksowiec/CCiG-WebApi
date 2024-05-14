using CCiG_WebApi.Models.Schedule;
using CCiG_WebApi.Models.Worker;
using Microsoft.EntityFrameworkCore;

namespace CCiG_WebApi.Infrastructure.Persistance
{
    public class CCiG_DbContext : DbContext
    {
        public CCiG_DbContext(DbContextOptions<CCiG_DbContext> options) : base(options)
        {
        }

        public DbSet<ScheduleModel> Schedules { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
