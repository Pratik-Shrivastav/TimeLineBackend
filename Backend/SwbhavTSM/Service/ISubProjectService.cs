using SwbhavTSM.Entity;

namespace SwbhavTSM.Service
{
    public interface ISubProjectService
    {
        public SubProject AddSubProject(SubProject subProject);
        public IList<SubProject> GetAllSubProjects();
    }
}
