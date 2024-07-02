
namespace StorageSystem.Dtos
{
    public class CreateItemDTO
    {

        public required string Name { get; set; }

        public int Quantity { get; set; } = 0;

        public List<int> StorageBinsId { get; set; } = new List<int>();
    }
}
