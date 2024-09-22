using SwbhavTSM.Entity;

namespace SwbhavTSM.Repository
{
    public interface ITimelineRepository
    {
        public User GetAllTimeLines(int id);
        public Timeline AddTimeLine(Timeline timeline, int id);

        public void DeleteTimeLine(int id);
    }
}
