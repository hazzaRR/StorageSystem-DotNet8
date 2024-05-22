using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace StorageSystem.Models
{

    [Table("storagebin")]
    public class StorageBin
    {

        [Column("id", TypeName = nameof(SqlDbType.UniqueIdentifier))]
        public Guid Id { get; set; }

        [Column("locationId")]
        public int LocationId { get; set; }

        public required Location Location { get; set; }
    }
}
