using SwbhavTSM.Entity;

namespace SwbhavTSM.Service
{
    public interface IBatchService
    {
        public Batch AddBatch(Batch batch);
        public IList<Batch> GetAllBatch();
    }
}
