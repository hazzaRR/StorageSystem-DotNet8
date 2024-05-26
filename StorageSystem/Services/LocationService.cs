using Microsoft.EntityFrameworkCore;
using StorageSystem.Interfaces;
using StorageSystem.Models;

namespace StorageSystem.Services
{
    public class LocationService: ILocationService
    {

        private readonly AppDbContext _context;

        public LocationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Location> Create(Location location)
        {
            _context.Add(location);
            await _context.SaveChangesAsync();


            return location;
        }

        public async Task<Location> Delete(int id)
        {

            var loaction = await _context.Location.FirstOrDefaultAsync(loc => loc.Id == id);

            if (loaction == null)
            {
                return null;
            }
            _context.Location.Remove(loaction);

            await _context.SaveChangesAsync();


            return loaction;
        }

        public async Task<List<Location>> GetAll()
        {
            return await _context.Location.ToListAsync();
        }

        public async Task<Location> GetById(int id)
        {
            return await _context.Location.FirstOrDefaultAsync(location => location.Id == id);
        }

        public Task<Location> Update(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
