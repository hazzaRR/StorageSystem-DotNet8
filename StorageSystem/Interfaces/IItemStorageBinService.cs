using StorageSystem.Models;

namespace StorageSystem.Interfaces
{
    public interface IItemStorageBinService
    {
        public Task<bool> Add(Item item, List<int> binList);
    }
}
