using StorageSystem.Interfaces;
using StorageSystem.Models;

namespace StorageSystem.Services
{
    public class ItemService: IItemService
    {

        private AppDbContext _context;


        public ItemService(AppDbContext context)
        {
            _context = context;
        }

        public Task<Item> Create(Item item)
        {
            throw new NotImplementedException();
        }

        public Task<Item> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Item>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Item> Update(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
