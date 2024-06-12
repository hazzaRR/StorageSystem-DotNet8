﻿using Microsoft.AspNetCore.Mvc;
using Moq;
using StorageSystem.Controllers;
using StorageSystem.Interfaces;
using StorageSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem.Tests
{
    public class LocationControllerTests
    {

        private readonly LocationController _locationController;
        private readonly Mock<ILocationService> _locationService;


        public LocationControllerTests()
        {
            _locationService = new Mock<ILocationService>();
            _locationController = new LocationController(_locationService.Object);
        }


        [Fact]
        public async void GetAllLocations_ReturnsOkAndList()
        {
            //Arrange

            List<Location> locations = new List<Location>()
            {
                new Location
                {
                    Id = 1,
                    Name = "Garage"
                },
                new Location
                {
                    Id = 2,
                    Name = "Attic"
                },
            };


            _locationService.Setup(service => service.GetAll())
                .ReturnsAsync(locations);

            //Act

            var result = await _locationController.GetAll();

            //Assert

            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;

            Assert.NotNull(okResult);
            Assert.Equal(locations, okResult.Value);
        }


        [Fact]
        public async void GetLocationById_ReturnsOkAndLocationObject()
        {
            //Arrange

            Location location = new Location
            {
                Id = 1,
                Name = "Garage"
            };

            _locationService.Setup(service => service.GetById(location.Id)).
                ReturnsAsync(location);

            //Act

            var result = await _locationController.GetById(location.Id);



            //Assert

            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;

            Assert.NotNull(okResult);
            Assert.Equal(location, okResult.Value);
        }

        [Fact]
        public async void GetLocationById_ReturnsNotFound()
        {
            //Arrange

            Location location = new Location
            {
                Id = 1,
                Name = "Garage"
            };

            _locationService.Setup(service => service.GetById(location.Id)).
                ReturnsAsync(() => null);

            //Act

            var result = await _locationController.GetById(location.Id);



            //Assert

            Assert.IsType<NotFoundResult>(result);

            var notFoundResult = result as NotFoundResult;

            Assert.NotNull(notFoundResult);
        }
    }
}
