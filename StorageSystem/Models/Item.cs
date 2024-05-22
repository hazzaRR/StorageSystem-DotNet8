using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace StorageSystem.Models
{

    [Table("item")]
    public class Item
    {


        [Column("id", TypeName = nameof(SqlDbType.UniqueIdentifier))]
        public Guid Id { get; set; }


        [Column("name")]
        public required string Name { get; set; }


        [Column("quantity")]
        public int Quantity { get; set; } = 0;

        public ICollection<StorageBin> StorageBins { get; set; } = new List<StorageBin>();
    }
}
