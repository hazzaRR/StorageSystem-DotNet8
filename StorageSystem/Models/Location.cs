using System.ComponentModel.DataAnnotations.Schema;

namespace StorageSystem.Models
{

    [Table("location")]
    public class Location
    {

        [Column("id")]
        public int Id;

        [Column("name")]
        public string Name;
    }
}
