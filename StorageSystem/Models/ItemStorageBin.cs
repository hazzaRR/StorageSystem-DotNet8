using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorageSystem.Models
{


    [Table("item_storagebin")]
    public class ItemStorageBin
    {
        public int ItemId { get; set; }
        public int StorageBinId { get; set; }
        public StorageBin StorageBin { get; set; } = null!;
        public Item Item { get; set; } = null!;
    }
}
