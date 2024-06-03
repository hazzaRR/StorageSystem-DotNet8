using StorageSystem.Dtos;
using StorageSystem.Models;

namespace StorageSystem.Mappers
{
    public static class ItemMapper
    {


        public static Item ToItem(this CreateItemDTO itemDto)
        {


            Item item = new Item()
            {
                Name = itemDto.Name,
                Quantity = itemDto.Quantity
            };

            return item;


        }

        public static ItemDTO ToItemDTO(this Item item)
        {


            ItemDTO itemDto = new ItemDTO()
            {
                Name = item.Name,
                Quantity = item.Quantity,
                StorageBins = item.StorageBins.ToList()
            };

            return itemDto;


        }
    }
}
