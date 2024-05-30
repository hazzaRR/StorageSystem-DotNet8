using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorageSystem.Interfaces;
using StorageSystem.Models;

namespace StorageSystem.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemController : ControllerBase
    {


        private readonly IItemService _itemService;


        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _itemService.GetAll();
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

    }
}
