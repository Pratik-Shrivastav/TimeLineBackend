using SwbhavTSM.Entity;
using SwbhavTSM.Repository;

namespace SwbhavTSM.Service
{
    public class ActivityService : IActivityService
    {
        private IActivityRepository _activityRepository;
        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }
        public void DeleteActivity(int id)
        {
            _activityRepository.DeleteActicity(id);
        }

        public void UpdateActivity(int id, Activity updateActivity)
        {
            _activityRepository.UpdateActivity(id, updateActivity);

        }

    }
}
