using SwbhavTSM.Entity;
using SwbhavTSM.Repository;

namespace SwbhavTSM.Service
{
    public class TimelineService : ITimelineService
    {
        private ITimelineRepository _repository;

        public TimelineService(ITimelineRepository repository)
        {
            _repository = repository;
        }

        public IList<Timeline> GetAllTimeLines(string id) 
        {
            return _repository.GetAllTimeLines(int.Parse(id)).TimelineList;
        }

        public Timeline AddTimeLine(Timeline timeline, string id) 
        {
            return _repository.AddTimeLine(timeline,int.Parse(id));
        }

        public void DeleteTimeline(int id)
        {
            _repository.DeleteTimeLine(id);
        }


    }
}
