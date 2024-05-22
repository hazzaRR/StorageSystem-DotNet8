using StorageSystem.Models;

namespace StorageSystem.Services
{
    public class ItemStorageBinService
    {

        private AppDbContext _context;


        public ItemStorageBinService(AppDbContext context)
        {
            _context = context;
        }
    }
}
