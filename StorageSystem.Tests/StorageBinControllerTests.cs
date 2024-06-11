using Moq;
using StorageSystem.Controllers;
using StorageSystem.Interfaces;
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


    }
}
