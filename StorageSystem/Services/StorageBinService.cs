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

        public Task<StorageBin> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StorageBin>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<StorageBin> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<StorageBin> Update(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
