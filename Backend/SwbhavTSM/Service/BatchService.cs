using SwbhavTSM.Entity;
using SwbhavTSM.Repository;

namespace SwbhavTSM.Service
{
    public class BatchService: IBatchService
    {
        private IRepository<Batch> _repository;

        public BatchService(IRepository<Batch> repository)
        {
            _repository = repository;
        }

        public Batch AddBatch(Batch batch)
        {
            return _repository.Add(batch);
        }


        public IList<Batch> GetAllBatch()
        {
            return _repository.GetAll();

        }
    }
}
