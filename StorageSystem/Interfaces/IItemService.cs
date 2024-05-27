using StorageSystem.Models;

namespace StorageSystem.Interfaces
{
    public interface IItemService
    {

        Task<Item> GetById(int id);

        Task<List<Item>> GetAll();

        Task<Item> Create(Item item);

        Task<Item> Update(Item item);

        Task<Item> Delete(int id);

    }
}
