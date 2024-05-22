using StorageSystem.Models;

namespace StorageSystem.Interfaces
{
    public interface ILocationService
    {

        Task<Location> GetById(Guid id);

        Task<List<Location>> GetAll();

        Task<Location> Create(Location location);

        Task<Location> Update(Location location);

        Task<Location> Delete(Guid id);
    }
}
