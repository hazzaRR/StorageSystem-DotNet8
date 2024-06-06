using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorageSystem.Interfaces;

namespace StorageSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemStorageBinController : ControllerBase
    {


        private readonly IItemStorageBinService _itemStorageBinService;


        public ItemStorageBinController(IItemStorageBinService itemStorageBinService)
        {
            _itemStorageBinService = itemStorageBinService;
        }


        [HttpPost("/{itemId}/{binId}")]
        public async Task<IActionResult> AddItemToBin([FromRoute] int itemId, [FromRoute] int binId)
        {

            var result = await _itemStorageBinService.Add(itemId, binId);

            if (!result)
            {
                return BadRequest();
            }

            return Ok("Item successfully added to bin");
        }


    }
}
