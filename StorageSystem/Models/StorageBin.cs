using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace StorageSystem.Models
{

    [Table("storagebin")]
    public class StorageBin
    {

        [Column("id", TypeName = nameof(SqlDbType.UniqueIdentifier))]
        public Guid Id;

        [Column("locationId")]
        public int LocationId;

        public required Location Location;
    }
}
