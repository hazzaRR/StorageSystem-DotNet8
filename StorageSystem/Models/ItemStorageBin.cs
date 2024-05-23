using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace StorageSystem.Models
{


    [Table("item_storagebin")]
    public class ItemStorageBin
    {

        [Column("itemId")]
        public int ItemId { get; set; }


        [Column("binId")]
        public int StorageBinId { get; set; }
        public StorageBin StorageBin { get; set; } = null!;
        public Item Item { get; set; } = null!;
    }
}
