using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorageSystem.Interfaces;

namespace StorageSystem.Controllers
{
    [Route("api/item-bin")]
    [ApiController]
    [Authorize]
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
                return NotFound($"Item with the id {itemId} could not be added to bin {binId}, please check " +
                    $"that the item ID supplied and bin ID exist");
            }

            return Ok($"Item successfully added to bin {binId}");
        }

        [HttpDelete("/{itemId}/{binId}")]
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
