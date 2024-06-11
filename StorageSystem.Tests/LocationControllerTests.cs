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
    public class LocationControllerTests
    {

        private readonly LocationController _locationController;
        private readonly Mock<ILocationService> _locationService;


        public LocationControllerTests()
        {
            _locationService = new Mock<ILocationService>();
            _locationController = new LocationController(_locationService.Object);
        }
    }
}
