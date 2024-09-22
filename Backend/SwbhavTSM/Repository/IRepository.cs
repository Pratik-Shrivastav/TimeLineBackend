namespace SwbhavTSM.Repository
{
    public interface IRepository <T> where T : class
    {
        public IList<T> GetAll();
        public T Add(T item);
    }
}
