using StorageSystem.Interfaces;
using StorageSystem.Models;

namespace StorageSystem.Services
{
    public class ItemStorageBinService: IItemStorageBinService
    {

        private AppDbContext _context;


        public ItemStorageBinService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(int itemId, int binId)
        {
            ItemStorageBin ItemStorageBin = new ItemStorageBin()
            {
                ItemId = itemId,
                StorageBinId = binId
            };


            var model = await _context.ItemStorageBin.AddAsync(ItemStorageBin);

            if (model == null)
            {
                return false;
            }

            await _context.SaveChangesAsync();


            return true;
        }

        public async Task<bool> AddToMultipleBins(int itemId, List<int> binList)
        {
            for (int i = 0; i < binList.Count; i++)
            {

                ItemStorageBin ItemStorageBin = new ItemStorageBin()
                {
                    ItemId = itemId,
                    StorageBinId = binList[i]
                };


                var model = await _context.ItemStorageBin.AddAsync(ItemStorageBin);

                if (model == null)
                {
                    return false;
                }

            }

            await _context.SaveChangesAsync();


            return true;
        }
    }
}
