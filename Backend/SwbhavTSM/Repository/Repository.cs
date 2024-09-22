using Microsoft.EntityFrameworkCore;
using SwbhavTSM.Data;

namespace SwbhavTSM.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private UserDbContext _dbContext;
        private DbSet<T> _dbSet;

        public Repository(UserDbContext userDbContext)
        {
            _dbSet = userDbContext.Set<T>();
            _dbContext = userDbContext;

        }

        public IList<T> GetAll() 
        {
            return _dbSet.ToList();
        }
        public T Add(T item) 
        {
            _dbSet.Add(item);
            _dbContext.SaveChanges();
            return item;
        }
    }
}
