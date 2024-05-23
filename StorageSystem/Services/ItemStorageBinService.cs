using StorageSystem.Interfaces;
using StorageSystem.Models;

namespace StorageSystem.Services
{
    public class ItemStorageBinService: IItemStorageBinService
    {

        private AppDbContext _context;


        public ItemStorageBinService(AppDbContext context)
        {
            _context = context;
        }
    }
}
