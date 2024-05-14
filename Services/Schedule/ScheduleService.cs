using AutoMapper;
using CCiG_WebApi.Infrastructure.Repositories.Interfaces;
using CCiG_WebApi.Models.Schedule;

namespace CCiG_WebApi.Services.Schedule
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IMapper _mapper;

        public ScheduleService(IScheduleRepository scheduleRepository, IMapper mapper) 
        {
            _scheduleRepository = scheduleRepository;
            _mapper = mapper;
        }

        public async Task<List<ScheduleDTO>> GetAllSchedules()
        {
            var schedule = await _scheduleRepository.GetAllAsync();
            var dto = _mapper.Map<List<ScheduleDTO>>(schedule);

            return dto;
        }

        public async Task<List<ScheduleDTO>> GetScheduleByEmail(string email)
        {
            var schedule = await _scheduleRepository.GetByEmailAsync(email);
            var dto = _mapper.Map<List<ScheduleDTO>>(schedule);

            return dto;
        }
    }
}
