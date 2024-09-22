using Microsoft.EntityFrameworkCore;
using SwbhavTSM.Entity;

namespace SwbhavTSM.Data
{
    public class UserDbContext : DbContext
    {
        private string _connectionString;
        public DbSet<User> UserTable {  get; set; }
        public DbSet<Timeline> TimelineTable { get; set; }
        public DbSet<Activity> ActivityTable { get; set; }
        public DbSet<Project> ProjectTable { get; set; }
        public DbSet<SubProject> SubProjectTable { get; set; }
        public DbSet<Batch> BatchTable { get; set; }



        public UserDbContext()
        {
            _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SwabhavTSMDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
