using CCiG_WebApi.Models.Schedule;

namespace CCiG_WebApi.Services.Schedule
{
    public interface IScheduleService
    {
        Task<List<ScheduleDTO>> GetAllSchedules();
        Task<List<ScheduleDTO>> GetScheduleByEmail(string email);
    }
}
