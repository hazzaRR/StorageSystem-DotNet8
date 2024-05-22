using StorageSystem.Models;

namespace StorageSystem.Services
{
    public class ItemService
    {

        private AppDbContext _context;


        public ItemService(AppDbContext context)
        {
            _context = context;
        }
    }
}
