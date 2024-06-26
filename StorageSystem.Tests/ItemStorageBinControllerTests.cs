using Microsoft.AspNetCore.Mvc;
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
    public class ItemStorageBinControllerTests
    {

        private readonly ItemStorageBinController _itemStorageBinController;
        private readonly Mock<IItemStorageBinService> _itemStorageBinService;


        public ItemStorageBinControllerTests()
        {
            _itemStorageBinService = new Mock<IItemStorageBinService>();
            _itemStorageBinController = new ItemStorageBinController(_itemStorageBinService.Object);
        }


        [Fact]
        public async void AddItemToBin_ReturnsOk()
        {
            //Arrange

            Location location = new Location
            {
                Id = 1,
                Name = "Attic"
            };

            StorageBin bin = new StorageBin
            {
                Id = 1,
                Location = location
            };


            Item item = new Item
            {
                Id = 1,
                Name = "Zip Ties",
                Quantity = 4
            };

            _itemStorageBinService.Setup(service => service.Add(item.Id, bin.Id))
                .ReturnsAsync(true);


            //Act

            var result = await _itemStorageBinController.AddItemToBin(item.Id, bin.Id);

            //Assert

            Assert.IsType<OkObjectResult>(result);

            var okResult = (OkObjectResult) result;

            Assert.NotNull(okResult);

            Assert.Equal($"Item successfully added to bin {bin.Id}", okResult.Value);


        }


    }
}
