using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace StorageSystem.Models
{

    [Table("storagebin")]
    public class StorageBin
    {

        [Column("id")]
        public int Id { get; set; }


        [Column("locationId")]
        [JsonIgnore]
        public int LocationId { get; set; }

        public required Location Location { get; set; } = null!;

        public ICollection<Item> Items { get; } = new List<Item>();

    }
}
