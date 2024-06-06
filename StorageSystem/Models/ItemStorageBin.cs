using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace StorageSystem.Models
{


    [Table("ItemStorageBin")]
    public class ItemStorageBin
    {

        [Column("itemId")]
        public int ItemId { get; set; }


        [Column("binId")]
        public int StorageBinId { get; set; }
    }
}
