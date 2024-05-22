using StorageSystem.Models;

namespace StorageSystem.Interfaces
{
    public interface IStorageBinService
    {

        Task<StorageBin> GetById(Guid id);

        Task<List<StorageBin>> GetAll();

        Task<StorageBin> Create(Item item);

        Task<StorageBin> Update(Item item);

        Task<StorageBin> Delete(Guid id);

    }
}
