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
    public class ItemStorageBinControllerTests
    {

        private readonly ItemStorageBinController _itemStorageBinController;
        private readonly Mock<IItemStorageBinService> _itemStorageBinService;


        public ItemStorageBinControllerTests()
        {
            _itemStorageBinService = new Mock<IItemStorageBinService>();
            _itemStorageBinController = new ItemStorageBinController(_itemStorageBinService.Object);
        }


    }
}
