using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace StorageSystem.Models
{


    [Table("item_storagebin")]
    public class ItemStorageBin
    {

        [Column("itemId", TypeName = nameof(SqlDbType.UniqueIdentifier))]
        public Guid ItemId { get; set; }


        [Column("binId", TypeName = nameof(SqlDbType.UniqueIdentifier))]
        public Guid StorageBinId { get; set; }
        public StorageBin StorageBin { get; set; } = null!;
        public Item Item { get; set; } = null!;
    }
}
