using Microsoft.AspNetCore.Mvc;
using SwbhavTSM.Entity;
using SwbhavTSM.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwbhavTSM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        // GET: api/<ProjectController>
        [HttpGet]
        public IList<Project> Get()
        {
            return _projectService.GetAllProjects();
        }

        // POST api/<ProjectController>
        [HttpPost]
        public Project Post([FromBody] Project project)
        {
            return _projectService.AddProject(project);
        }

    }
}
