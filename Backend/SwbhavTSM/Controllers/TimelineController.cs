using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwbhavTSM.Entity;
using SwbhavTSM.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwbhavTSM.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TimelineController : ControllerBase
    {
        private ITimelineService _timelineService;
        public TimelineController(ITimelineService timelineService)
        {
            _timelineService = timelineService;
        }

        // GET: api/<TimelineController>
        [HttpGet]
        public IEnumerable<Timeline> Get()
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            return _timelineService.GetAllTimeLines(userIdClaim);
        }

        // POST api/<TimelineController>
        [HttpPost]
        public Timeline Post([FromBody] Timeline timeline)
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            return _timelineService.AddTimeLine(timeline, userIdClaim);

        }

        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
            _timelineService.DeleteTimeline(id);
        }
    }
}
