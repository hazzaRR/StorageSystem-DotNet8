using StorageSystem.Models;

namespace StorageSystem.Services
{
    public class LocationService
    {

        private AppDbContext _context;

        public LocationService(AppDbContext context)
        {
            _context = context;
        }
    }
}
