using Microsoft.AspNetCore.Mvc;
using SwbhavTSM.Entity;
using SwbhavTSM.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwbhavTSM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        private IBatchService _batchService;
        public BatchController(IBatchService batchService) 
        {
            _batchService = batchService;
        }
        // GET: api/<BatchController>
        [HttpGet]
        public IList<Batch> Get()
        {
            return _batchService.GetAllBatch();
        }

        // POST api/<BatchController>
        [HttpPost]
        public Batch Post([FromBody] Batch batch)
        {
            return _batchService.AddBatch(batch);   
        }

       
    }
}
