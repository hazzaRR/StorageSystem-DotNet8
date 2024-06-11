using Moq;
using StorageSystem.Controllers;
using StorageSystem.Interfaces;
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
    }
}
