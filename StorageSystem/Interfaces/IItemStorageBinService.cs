using StorageSystem.Models;

namespace StorageSystem.Interfaces
{
    public interface IItemStorageBinService
    {
        public Task<bool> AddToMultipleBins(int itemId, List<int> binList);

        public Task<bool> Add(int itemId, int binId);
    }
}
