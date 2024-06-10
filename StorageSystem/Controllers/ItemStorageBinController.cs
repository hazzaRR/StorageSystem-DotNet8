using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorageSystem.Interfaces;

namespace StorageSystem.Controllers
{
    [Route("api/item-bin")]
    [ApiController]
    public class ItemStorageBinController : ControllerBase
    {


        private readonly IItemStorageBinService _itemStorageBinService;


        public ItemStorageBinController(IItemStorageBinService itemStorageBinService)
        {
            _itemStorageBinService = itemStorageBinService;
        }


        [HttpPost("/{itemId}/{binId}")]
        [Authorize]
        public async Task<IActionResult> AddItemToBin([FromRoute] int itemId, [FromRoute] int binId)
        {

            var result = await _itemStorageBinService.Add(itemId, binId);

            if (!result)
            {
                return BadRequest();
            }

            return Ok("Item successfully added to bin");
        }

        [HttpDelete("/{itemId}/{binId}")]
        [Authorize]
        public async Task<IActionResult> DeleteItemToBin([FromRoute] int itemId, [FromRoute] int binId)
        {

            var result = await _itemStorageBinService.Delete(itemId, binId);

            if (!result)
            {
                return BadRequest($"The Item with the id: {itemId} was not found in bin {binId}");
            }

            return Ok("Successfully delete item from bin");
        }



    }
}
