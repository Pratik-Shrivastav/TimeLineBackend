using Microsoft.EntityFrameworkCore;
using SwbhavTSM.Data;
using SwbhavTSM.Entity;

namespace SwbhavTSM.Repository
{
    public class TimelineRepository : ITimelineRepository
    {
        private UserDbContext _userDbContext;
        public TimelineRepository(UserDbContext userDbContext) 
        {
            _userDbContext = userDbContext;
        }
        public User GetAllTimeLines(int id)
        {
            return _userDbContext.UserTable.Include(x => x.TimelineList).ThenInclude(o => o.ActivityList).FirstOrDefault(y=>y.Id==id);
        }

        public Timeline AddTimeLine(Timeline timeline,int id)
        {
            // if activities for the date already exits
            User checkUserList = _userDbContext.UserTable.Include(x => x.TimelineList).ThenInclude(o => o.ActivityList).FirstOrDefault(y => y.Id == id);
            if (checkUserList != null)
            {
                foreach (Timeline timelineObject in checkUserList.TimelineList)
                {
                    if (timelineObject.Date == timeline.Date)
                    {
                        //timelineObject.ActivityList = new List<Activity>();
                        foreach (Activity activity in timeline.ActivityList)
                        {
                            timelineObject.ActivityList.Add(activity);
                        }
                        _userDbContext.SaveChanges();
                        return timeline;
                    }
                }
            }

            //---------------------------------------------------------

            checkUserList.TimelineList.Add(timeline);
            _userDbContext.SaveChanges();
            return timeline;
        }

        public void DeleteTimeLine(int id)
        {
            Timeline deleteTimeline = _userDbContext.TimelineTable.FirstOrDefault(x=>x.Id==id);
            _userDbContext.TimelineTable.Remove(deleteTimeline);
            _userDbContext.SaveChanges();
        }

    }
}
