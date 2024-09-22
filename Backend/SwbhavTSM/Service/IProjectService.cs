using SwbhavTSM.Entity;

namespace SwbhavTSM.Service
{
    public interface IProjectService
    {
        public Project AddProject(Project project);
        public IList<Project> GetAllProjects();
    }
}
