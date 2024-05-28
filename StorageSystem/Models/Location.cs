using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace StorageSystem.Models
{

    [Table("location")]
    public class Location
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public required string Name { get; set; }


        [JsonIgnore]
        public ICollection<StorageBin> StorageBins { get; } = new List<StorageBin>();
    }
}
