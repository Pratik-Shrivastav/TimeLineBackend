namespace SwbhavTSM.Entity
{
    public class Timeline
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public bool OnLeave { get; set; }
        public List<Activity>? ActivityList { get; set; }
    }
}
