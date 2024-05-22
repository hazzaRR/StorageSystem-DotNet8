﻿using StorageSystem.Interfaces;
using StorageSystem.Models;

namespace StorageSystem.Services
{
    public class LocationService: ILocationService
    {

        private AppDbContext _context;

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
