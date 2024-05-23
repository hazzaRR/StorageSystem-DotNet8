using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace StorageSystem.Models
{

    [Table("storagebin")]
    public class StorageBin
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("locationId")]
        public int LocationId { get; set; }

        public required Location Location { get; set; } = null!;

        public ICollection<Item> Items { get; } = new List<Item>();

    }
}
