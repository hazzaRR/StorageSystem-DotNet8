using StorageSystem.Models;
using StorageSystem.Dtos;

namespace StorageSystem.Interfaces
{
    public interface IStorageBinService
    {

        Task<StorageBin> GetById(int id);

        Task<List<StorageBin>> GetAll();

        Task<StorageBin> Create(CreateStorageBinDto storageBin);

        Task<StorageBin> Update(StorageBin storageBin);

        Task<StorageBin> Delete(int id);

    }
}
