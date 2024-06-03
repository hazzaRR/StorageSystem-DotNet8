using StorageSystem.Models;

namespace StorageSystem.Dtos
{
    public class ItemDTO
    {

        public required string Name { get; set; }

        public int Quantity { get; set; } = 0;

        public List<StorageBin> StorageBins { get; set; } = new List<StorageBin>();
    }
}
