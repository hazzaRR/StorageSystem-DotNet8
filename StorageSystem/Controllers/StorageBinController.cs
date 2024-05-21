using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StorageSystem.Controllers
{
    [Route("api/bin")]
    [ApiController]
    public class StorageBinController : ControllerBase
    {

        [HttpGet]
        public IActionResult index()
        {
            return Ok("hello world");
        }
    }
}
