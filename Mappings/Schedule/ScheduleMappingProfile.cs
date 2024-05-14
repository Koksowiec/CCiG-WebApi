using AutoMapper;
using CCiG_WebApi.Models.Schedule;

namespace CCiG_WebApi.Mappings.Schedule
{
    public class ScheduleMappingProfile : Profile
    {
        public ScheduleMappingProfile() 
        {
            CreateMap<ScheduleModel, ScheduleDTO>();
        }
    }
}
