using StorageSystem.Models;

namespace StorageSystem.Interfaces
{
    public interface IItemService
    {

        Task<Item> GetById(Guid id);

        Task<List<Item>> GetAll();

        Task<Item> Create(Item item);

        Task<Item> Update(Item item);

        Task<Item> Delete(Guid id);

    }
}
