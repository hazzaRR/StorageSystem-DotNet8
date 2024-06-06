using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorageSystem.Services;

namespace StorageSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemStorageBinController : ControllerBase
    {


        private readonly ItemStorageBinService _itemStorageBinService;


        public ItemStorageBinController(ItemStorageBinService itemStorageBinService)
        {
            _itemStorageBinService = itemStorageBinService;
        }
    }
}
