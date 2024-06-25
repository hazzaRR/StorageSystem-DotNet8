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
    public class ItemControllerTests
    {

        private readonly ItemController _itemController;
        private readonly Mock<IItemService> _itemService;
        private readonly Mock<IItemStorageBinService> _itemStorageBinService;

        public ItemControllerTests()
        {
            _itemService = new Mock<IItemService>();
            _itemStorageBinService = new Mock<IItemStorageBinService>();
            _itemController = new ItemController(_itemService.Object, _itemStorageBinService.Object);
        }


        [Fact]
        public async void GetAllItems_ReturnsOk_AndList()
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

            List<Item> items = new List<Item>() {

                new Item
                {
                    Id = 1,
                    Name = "Zip Ties",
                    Quantity = 4
                },
                new Item
                {
                    Id = 2,
                    Name = "Spoon",
                    Quantity = 1
                }

            };

            _itemService.Setup(service => service.GetAll())
                .ReturnsAsync(items);

            //Act


            var result = await _itemController.GetAll();


            //Assert

            Assert.IsType<OkObjectResult>(result);

            var okResult = (OkObjectResult)result;

            Assert.NotNull(okResult);

            Assert.Equal(items, okResult.Value);

        }


        [Fact]
        public async void GetItemById_ReturnsOkAndItemObject()
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


            _itemService.Setup(service => service.GetById(item.Id))
                .ReturnsAsync(item);

            //Act


            var result = await _itemController.GetById(item.Id);


            //Assert

            Assert.IsType<OkObjectResult>(result);

            var okResult = (OkObjectResult)result;

            Assert.NotNull(okResult);

            Assert.Equal(item, okResult.Value);

        }

        [Fact]
        public async void GetItemById_ReturnsNotFound()
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


            _itemService.Setup(service => service.GetById(item.Id))
                .ReturnsAsync(() => null);

            //Act


            var result = await _itemController.GetById(item.Id);


            //Assert

            Assert.IsType<NotFoundObjectResult>(result);

            var notFoundResult = (NotFoundObjectResult)result;

            Assert.NotNull(notFoundResult);


        }

    }

}
