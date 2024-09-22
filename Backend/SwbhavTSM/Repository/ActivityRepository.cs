using Microsoft.EntityFrameworkCore;
using SwbhavTSM.Data;
using SwbhavTSM.Entity;

namespace SwbhavTSM.Repository
{
    public class ActivityRepository : IActivityRepository
    {
        private UserDbContext _context;

        public ActivityRepository(UserDbContext context)
        {
            _context = context;
        }

        public void DeleteActicity(int id)
        {
            Activity deleteActivity = _context.ActivityTable.Find(id);
            Timeline timeline = _context.TimelineTable.Include(o => o.ActivityList).FirstOrDefault(x => x.Date == deleteActivity.Date);
            if (timeline.ActivityList.Count==1) 
            {
                _context.ActivityTable.Remove(deleteActivity);
                _context.TimelineTable.Remove(timeline);
                _context.SaveChanges();
            }
            else
            {
                _context.ActivityTable.Remove(deleteActivity);
                _context.SaveChanges();
            }
        }
        public void UpdateActivity(int id, Activity updatedActivity) 
        {
            Activity oldActivity =_context.ActivityTable.FirstOrDefault(x => x.Id == id);
            if (oldActivity != null) 
            {
                oldActivity.ProjectName = updatedActivity.ProjectName;
                oldActivity.SubProjectName = updatedActivity.SubProjectName;
                oldActivity.BatchName = updatedActivity.BatchName;
                oldActivity.Hours = updatedActivity.Hours;
                oldActivity.Minutes = updatedActivity.Minutes;
                oldActivity.Comments = updatedActivity.Comments;

                _context.SaveChanges();

            }
        }
    }
}
