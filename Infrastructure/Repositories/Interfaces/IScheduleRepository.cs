using CCiG_WebApi.Models.Schedule;

namespace CCiG_WebApi.Infrastructure.Repositories.Interfaces
{
    public interface IScheduleRepository
    {
        Task<List<ScheduleModel>> GetAllAsync();
        Task<List<ScheduleModel>> GetByEmailAsync(string email);
    }
}
