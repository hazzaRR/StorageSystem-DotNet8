using System.ComponentModel.DataAnnotations.Schema;

namespace StorageSystem.Models
{

    [Table("storagebin")]
    public class StorageBin
    {

        [Column("id")]
        public int Id;

        [Column("locationId")]
        public int LocationId;

        public required Location Location;
    }
}
