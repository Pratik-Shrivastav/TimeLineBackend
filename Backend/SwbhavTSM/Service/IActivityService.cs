using SwbhavTSM.Entity;

namespace SwbhavTSM.Service
{
    public interface IActivityService
    {
        public void DeleteActivity(int id);
        public void UpdateActivity(int id, Activity updateActivity);
    }
}
