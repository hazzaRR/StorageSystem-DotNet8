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
            await _context.AddAsync(location);
            await _context.SaveChangesAsync();


            return location;
        }

        public Task<Location> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Location>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Location> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Location> Update(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
