using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace StorageSystem.Models
{

    [Table("location")]
    public class Location
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public ICollection<StorageBin> StorageBins { get; } = new List<StorageBin>();
    }
}
