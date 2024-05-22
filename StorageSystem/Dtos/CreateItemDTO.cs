using StorageSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorageSystem.Dtos
{
    public class CreateItemDTO
    {

        public required string Name { get; set; }

        public int Quantity { get; set; } = 0;

        public List<Guid> StorageBinsId { get; set; } = new List<Guid>();
    }
}
