using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorageSystem.Interfaces;

namespace StorageSystem.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemController : ControllerBase
    {


        private IItemService _itemService;


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


    }
}
