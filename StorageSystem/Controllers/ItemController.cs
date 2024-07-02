using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StorageSystem.Dtos;
using StorageSystem.Interfaces;
using StorageSystem.Mappers;
using StorageSystem.Models;

namespace StorageSystem.Controllers
{
    [Route("api/item")]
    [ApiController]
    [Authorize]
    public class ItemController : ControllerBase
    {


        private readonly IItemService _itemService;
        private readonly IItemStorageBinService _itemStorageBinService;


        public ItemController(IItemService itemService, IItemStorageBinService itemStorageBinService)
        {
            _itemService = itemService;
            _itemStorageBinService = itemStorageBinService;
        }



        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _itemService.GetAll();
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].StorageBins.ToList().Count);
            }
            return Ok(items);

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
           Item? item = await _itemService.GetById(id);


            if (item == null)
            {
                return NotFound($"No Item with the id {id} was found");
            }

            return Ok(item);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {

            Item? item = await _itemService.Delete(id);


            if (item == null)
            {
                return NotFound($"No item with the id {id} was found, and cannot be deleted");
            }

            return NoContent();

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateItemDTO itemDTO)
        {

            Item item = itemDTO.ToItem();
            var itemModel = await _itemService.Create(item);

            if (itemModel == null)
            {
                return NotFound();
            }


            if (itemDTO.StorageBinsId.Count > 0)
            {

                bool result = await _itemStorageBinService.AddToMultipleBins(item.Id, itemDTO.StorageBinsId);

                if (!result)
                {
                    return NotFound();
                }

            }


            return Created();
        }

        [HttpPut("quantity/{id}")]
        public async Task<IActionResult> UpdateQuantity([FromRoute] int id, [FromBody] int quantity)
        {
            var item = await _itemService.UpdateQuantity(id, quantity);

            return Ok();
        }

    }
}
