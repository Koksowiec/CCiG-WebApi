using CCiG_WebApi.Infrastructure.Persistance;
using CCiG_WebApi.Infrastructure.Repositories.Interfaces;
using CCiG_WebApi.Models.Schedule;
using Microsoft.EntityFrameworkCore;

namespace CCiG_WebApi.Infrastructure.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly CCiG_DbContext _dbContext;

        public ScheduleRepository(CCiG_DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<ScheduleModel>> GetAllAsync()
        {
            var schedule = await _dbContext.Schedules.Include(s => s.Employee).ToListAsync();
            return schedule;
        }

        public async Task<List<ScheduleModel>> GetByEmailAsync(string email)
        {
            var schedule = await _dbContext.Schedules.Where(s => s.Employee.Email == email).ToListAsync();
            return schedule;
        }
    }
}
