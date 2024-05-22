using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace StorageSystem.Models
{

    [Table("location")]
    public class Location
    {

        [Column("id", TypeName = nameof(SqlDbType.UniqueIdentifier))]
        public Guid Id;

        [Column("name")]
        public string Name;
    }
}
