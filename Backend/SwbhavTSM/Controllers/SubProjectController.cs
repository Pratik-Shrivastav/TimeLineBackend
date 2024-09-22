using Microsoft.AspNetCore.Mvc;
using SwbhavTSM.Entity;
using SwbhavTSM.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwbhavTSM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubProjectController : ControllerBase
    {
        private ISubProjectService _subProjectService;
        public SubProjectController(ISubProjectService subProjectService)
        {
            _subProjectService = subProjectService;
        }

        // GET: api/<SubProjectController>
        [HttpGet]
        public IList<SubProject> Get()
        {
            return _subProjectService.GetAllSubProjects();
        }


        // POST api/<SubProjectController>
        [HttpPost]
        public SubProject Post([FromBody] SubProject subProject)
        {
            return _subProjectService.AddSubProject(subProject);
        }
    }
}
