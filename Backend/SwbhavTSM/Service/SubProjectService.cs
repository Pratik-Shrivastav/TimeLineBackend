using SwbhavTSM.Entity;
using SwbhavTSM.Repository;

namespace SwbhavTSM.Service
{
    public class SubProjectService : ISubProjectService
    {
        private IRepository<SubProject> _repository;

        public SubProjectService(IRepository<SubProject> repository)
        {
            _repository = repository;
        }

        public SubProject AddSubProject(SubProject subProject)
        {
            return _repository.Add(subProject);
        }

        public IList<SubProject> GetAllSubProjects()
        {
            return _repository.GetAll();
        }
    }
}
