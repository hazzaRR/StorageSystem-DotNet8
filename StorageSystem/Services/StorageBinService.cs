using Microsoft.EntityFrameworkCore;
using StorageSystem.Dtos;
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

        public async Task<StorageBin> Create(CreateStorageBinDto storageBinDto)
        {
            Location location = await _context.Location.FirstOrDefaultAsync(location => location.Id == storageBinDto.LocationDto.Id);

            if (location == null)
            {
                return null;
            }
            StorageBin storageBin = new StorageBin()
            {
                Location = location
            };
            await _context.StorageBin.AddAsync(storageBin);
            await _context.SaveChangesAsync();

            return storageBin;
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

        public Task<StorageBin> Update(StorageBin storageBin)
        {
            throw new NotImplementedException();
        }
    }
}
