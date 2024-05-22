using StorageSystem.Models;
using System.Data;

namespace StorageSystem.Dtos
{
    public class CreateStorageBinDto
    {
        public int LocationId { get; set; }

        public Location Location {  get; set; }
    }
}
