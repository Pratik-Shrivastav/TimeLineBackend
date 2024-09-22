using SwbhavTSM.Entity;

namespace SwbhavTSM.Service
{
    public interface ITimelineService
    {
        public IList<Timeline> GetAllTimeLines(string id);
        public Timeline AddTimeLine(Timeline timeline, string id);

        public void DeleteTimeline(int id);
    }
}
