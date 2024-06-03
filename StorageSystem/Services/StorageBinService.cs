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

        public async Task<StorageBin> Create(CreateStorageBinDTO storageBinDto)
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

        public async Task<StorageBin> Delete(int id)
        {
            StorageBin? storageBin = await _context.StorageBin.FirstOrDefaultAsync(bin => bin.Id == id);

            if (storageBin == null)
            {
                return null;
            }

            _context.Remove(storageBin);

            await _context.SaveChangesAsync();

            return storageBin;
        }

        public async Task<List<StorageBin>> GetAll()
        {
            return await _context.StorageBin.ToListAsync();
        }

        public async Task<StorageBin> GetById(int id)
        {
            return await _context.StorageBin.FirstOrDefaultAsync(bin => bin.Id == id);
        }

        public async Task<StorageBin> Update(int id, int locationId)
        {
            StorageBin? storageBin = await _context.StorageBin.FirstOrDefaultAsync(bin => bin.Id == id);

            if (storageBin == null)
            {
                return null;
            }

            Location? location = await _context.Location.FirstOrDefaultAsync(location => location.Id == locationId);

            if (location == null)
            {
                return null;
            }

            storageBin.Location = location;

            await _context.SaveChangesAsync();

            return storageBin;
        }
    }
}
