using StorageSystem.Dtos;
using StorageSystem.Models;

namespace StorageSystem.Interfaces
{
    public interface ILocationService
    {

        Task<Location> GetById(int id);

        Task<List<Location>> GetAll();

        Task<Location> Create(Location location);

        Task<Location> Update(Location location, CreateLocationDTO locationDTO);

        Task<Location> Delete(int id);
    }
}
