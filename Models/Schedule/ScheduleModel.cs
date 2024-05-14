using CCiG_WebApi.Models.Worker;

namespace CCiG_WebApi.Models.Schedule
{
    public class ScheduleModel
    {
        public int Id { get; set; }
        public EmployeeModel Employee { get; set; } = new();
        public string WorkingDay { get; set; } = default!;
        public string WorkStart { get; set; } = default!;
        public string WorkEnd { get; set; } = default!;
    }
}
