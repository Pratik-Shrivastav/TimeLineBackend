using SwbhavTSM.Entity;

namespace SwbhavTSM.Repository
{
    public interface IActivityRepository
    {
        public void DeleteActicity(int id);
        public void UpdateActivity(int id, Activity updatedActivity);
    }
}
