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
    public class ActivityController : ControllerBase
    {
        private IActivityService _activityService;
        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        // POST api/<ActivityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ActivityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Activity activity)
        {

            _activityService.UpdateActivity(id, activity);

        }

        // DELETE api/<ActivityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _activityService.DeleteActivity(id);
        }
    }
}
