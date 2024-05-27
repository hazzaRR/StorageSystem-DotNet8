using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorageSystem.Dtos;
using StorageSystem.Interfaces;
using StorageSystem.Mappers;

namespace StorageSystem.Controllers
{
    [Route("api/location")]
    [ApiController]
    public class LocationController : ControllerBase
    {


        private ILocationService _locationService;


        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {

            var location = await _locationService.GetById(id);

            if (location == null)
            {
                return NotFound();

            }

            return Ok(location);

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var locations = await _locationService.GetAll();

            return Ok(locations);

        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateLocationDTO locationDTO)
        {

            var location = await _locationService.Create(locationDTO.ToLocation());


            return Created("", location.ToLocationDTO());

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id) 
        {
            var location = await _locationService.Delete(id);

            if (location == null)
            {
                return NotFound($"No location with the Id {id} could be found");
            }
            return NoContent();

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] CreateLocationDTO locationDTO)
        {

            var location = await _locationService.GetById(id);

            if (location == null)
            {
                return NotFound($"No location with the Id: {id}");
            }

            await _locationService.Update(location, locationDTO);


            return NoContent();


        }
    }
}
