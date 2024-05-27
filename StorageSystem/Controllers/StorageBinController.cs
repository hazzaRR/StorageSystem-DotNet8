using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorageSystem.Interfaces;

namespace StorageSystem.Controllers
{
    [Route("api/bin")]
    [ApiController]
    public class StorageBinController : ControllerBase
    {

        private IStorageBinService _storageBinService;

        public StorageBinController(IStorageBinService storageBinService)
        {
            _storageBinService = storageBinService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var bins = await _storageBinService.GetAll();

            return Ok(bins);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var bin = await _storageBinService.GetById(id);

            if (bin == null)
            {
                return NotFound($"No storage bin the id: {id}");
            }

            return Ok(bin);
        }
    }
}
