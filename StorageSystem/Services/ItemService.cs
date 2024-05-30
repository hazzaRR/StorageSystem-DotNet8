using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Item>> GetAll()
        {
            return await _context.Item.ToListAsync();
        }

        public async Task<Item?> GetById(int id)
        {
            return await _context.Item.FirstOrDefaultAsync(item => item.Id == id);
        }

        public Task<Item> Update(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
