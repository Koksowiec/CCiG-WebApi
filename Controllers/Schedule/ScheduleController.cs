using Microsoft.AspNetCore.Mvc;
using CCiG_WebApi.Models.Schedule;
using CCiG_WebApi.Services.Schedule;

namespace CCiG_WebApi.Controllers.Schedule
{
    [ApiController]
    [Route("[controller]")]
    public class ScheduleController : Controller
    {
        private IScheduleService _scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpGet(Name = "GetSchedule")]
        public async Task<IActionResult> Get()
        {
            var result = await _scheduleService.GetAllSchedules();
            return Json(result);
        }

        [HttpPost(Name = "GetScheduleByEmail")]
        public async Task<IActionResult> Post(string email)
        {
            var result = await _scheduleService.GetScheduleByEmail(email);
            return Json(result);
        }
    }
}
