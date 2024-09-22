namespace SwbhavTSM.Entity
{
    public class Activity
    {
        public int Id { get; set; }
        public string? Date { get; set; }
        public string ProjectName { get; set; } 
        public string SubProjectName { get; set; }
        public string BatchName     { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public string Comments { get; set; }

    }
}
