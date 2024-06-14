using Microsoft.AspNetCore.Mvc;
using Moq;
using StorageSystem.Controllers;
using StorageSystem.Interfaces;
using StorageSystem.Models;
using StorageSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem.Tests
{
    public class StorageBinControllerTests
    {

        private readonly StorageBinController _storageBinController;
        private readonly Mock<IStorageBinService> _storageBinService;


        public StorageBinControllerTests()
        {
            _storageBinService = new Mock<IStorageBinService>();
            _storageBinController = new StorageBinController(_storageBinService.Object);
        }


        [Fact]
        public async void GetAllStorageBins_ReturnsOkAndList()
        {
            //Arrange

            Location location = new Location
            {
                Id = 1,
                Name = "Garage"

            };
            List<StorageBin> bins = new List<StorageBin>()
            {
                new StorageBin
                {
                    Id = 1,
                    Location = location,
                },
                new StorageBin
                {
                    Id = 2,
                    Location = location,
                }
            };


            _storageBinService.Setup(service => service.GetAll())
                .ReturnsAsync(bins);

            //Act

            var result = await _storageBinController.GetAll();

            //Assert

            Assert.IsType<OkObjectResult>(result);

            var okResult = result as OkObjectResult;

            Assert.NotNull(okResult);
            Assert.Equal(bins, okResult.Value);
        }


        [Fact]
        public async void GetStorageBinById_ReturnsOkAndObject()
        {
            //Arrange
            StorageBin bin = new StorageBin
            {
                Id = 1,
                Location = new Location
                {
                    Id = 1,
                    Name = "Garage"

                }
            };


            _storageBinService.Setup(service => service.GetById(bin.Id))
                .ReturnsAsync(bin);


            //Act
            var result = await _storageBinController.GetById(bin.Id);

            //Assert

            Assert.IsType<OkObjectResult>(result);

            var okResult = result as OkObjectResult;

            Assert.NotNull(okResult);
            Assert.Equal(bin, okResult.Value);

        }

        [Fact]
        public async void GetStorageBinById_ReturnsNotFound()
        {
            //Arrange
            StorageBin bin = new StorageBin
            {
                Id = 1,
                Location = new Location
                {
                    Id = 1,
                    Name = "Garage"

                }
            };


            _storageBinService.Setup(service => service.GetById(bin.Id))
                .ReturnsAsync(() => null);


            //Act
            var result = await _storageBinController.GetById(bin.Id);

            //Assert

            Assert.IsType<NotFoundObjectResult>(result);

            var notFoundResult = result as NotFoundObjectResult;

            Assert.NotNull(notFoundResult);

        }

    }
}
