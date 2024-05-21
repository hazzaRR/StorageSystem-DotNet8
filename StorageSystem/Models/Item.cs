using System.ComponentModel.DataAnnotations.Schema;

namespace StorageSystem.Models
{

    [Table("item")]
    public class Item
    {


        [Column("id")]
        public int Id { get; set; }


        [Column("name")]
        public required string Name { get; set; }


        [Column("quantity")]
        public int Quantity { get; set; } = 0;

        public ICollection<StorageBin> StorageBins { get; set; } = new List<StorageBin>();
    }
}
