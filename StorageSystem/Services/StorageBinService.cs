using Microsoft.EntityFrameworkCore;
using StorageSystem.Interfaces;
using StorageSystem.Models;

namespace StorageSystem.Services
{
    public class StorageBinService: IStorageBinService
    {

        private AppDbContext _context;

        public StorageBinService(AppDbContext context)
        {
            _context = context;
        }

        public Task<StorageBin> Create(Item item)
        {
            throw new NotImplementedException();
        }

        public Task<StorageBin> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StorageBin>> GetAll()
        {
            return await _context.StorageBin.ToListAsync();
        }

        public async Task<StorageBin> GetById(int id)
        {
            return await _context.StorageBin.FirstOrDefaultAsync(bin => bin.Id == id);
        }

        public Task<StorageBin> Update(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
