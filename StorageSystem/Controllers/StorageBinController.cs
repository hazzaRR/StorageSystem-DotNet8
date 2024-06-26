﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorageSystem.Dtos;
using StorageSystem.Interfaces;
using StorageSystem.Mappers;
using StorageSystem.Models;

namespace StorageSystem.Controllers
{
    [Route("api/bin")]
    [ApiController]
    [Authorize]
    public class StorageBinController : ControllerBase
    {

        private readonly IStorageBinService _storageBinService;

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

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateStorageBinDTO storageBinDto)
        {


            var storageBinModel = await _storageBinService.Create(storageBinDto);

            if (storageBinModel == null)
            {
                return NotFound($"Location with Id {storageBinDto.LocationDto.Id} not found.");
            }


            return Created("", storageBinModel);

        }

        [HttpPut("{id}/{locationId}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromRoute] int locationId)
        {

            var storageBinModel = await _storageBinService.Update(id, locationId);

            if (storageBinModel == null)
            {
                return NotFound($"Storage Bin with Id {id} not found.");
            }


            return NoContent();


        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {

            StorageBin? storageBinModel = await _storageBinService.Delete(id);

            if (storageBinModel == null)
            {
                return NotFound($"Could not find Storage bin with id: {id}");
            }

            return NoContent();

        }


    }
}
