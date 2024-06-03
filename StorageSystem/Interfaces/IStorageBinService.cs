using StorageSystem.Models;
using StorageSystem.Dtos;

namespace StorageSystem.Interfaces
{
    public interface IStorageBinService
    {

        Task<StorageBin> GetById(int id);

        Task<List<StorageBin>> GetAll();

        Task<StorageBin> Create(CreateStorageBinDTO storageBin);

        Task<StorageBin> Update(int id, int locationId);

        Task<StorageBin> Delete(int id);

    }
}
