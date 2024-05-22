using StorageSystem.Models;

namespace StorageSystem.Interfaces
{
    public interface ILocationService
    {

        Task<Location> GetById(Guid id);

        Task<List<Location>> GetAll();

        Task<Location> Create(Item item);

        Task<Location> Update(Item item);

        Task<Location> Delete(Guid id);
    }
}
