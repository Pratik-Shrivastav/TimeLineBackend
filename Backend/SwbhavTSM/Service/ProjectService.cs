using SwbhavTSM.Entity;
using SwbhavTSM.Repository;

namespace SwbhavTSM.Service
{
    public class ProjectService : IProjectService
    {
        private IRepository<Project> _repository;

        public ProjectService(IRepository<Project> repository)
        {
            _repository = repository;
        }

        public Project AddProject(Project project) 
        {
            return _repository.Add(project);
        }

        public IList<Project> GetAllProjects()
        {
            return _repository.GetAll();

        }
    }
}
