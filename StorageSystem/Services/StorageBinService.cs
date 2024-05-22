using StorageSystem.Models;

namespace StorageSystem.Services
{
    public class StorageBinService
    {

        private AppDbContext _context;

        public StorageBinService(AppDbContext context)
        {
            _context = context;
        }
    }
}
