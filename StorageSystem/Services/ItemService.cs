using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using StorageSystem.Dtos;
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

        public async Task<Item> Create(Item item)
        {
            var itemModel = _context.Item.AddAsync(item);

            await _context.SaveChangesAsync();

            return item;

        }

        public async Task<Item> Delete(int id)
        {
            Item? item = await _context.Item.FirstOrDefaultAsync(item => item.Id == id);

            if (item == null)
            {
                return null;
            }

            _context.Item.Remove(item);

            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<List<Item>> GetAll()
        {
            return await _context.Item
                .Include(item => item.StorageBins)
                .ThenInclude(bin => bin.Location)
                .ToListAsync();
        }

        public async Task<Item?> GetById(int id)
        {
            return await _context.Item.Include(item => item.StorageBins).FirstOrDefaultAsync(item => item.Id == id);
        }

        public Task<Item> Update(Item item)
        {
            throw new NotImplementedException();
        }

        public async Task<Item> UpdateQuantity(int id, int quantity)
        {
            Item? itemModel = await _context.Item.FirstOrDefaultAsync(item => item.Id == id);


            if (itemModel == null)
            {
                return null;
            }

            itemModel.Quantity = quantity;

            await _context.SaveChangesAsync();


            return itemModel;
        }
    }
}
