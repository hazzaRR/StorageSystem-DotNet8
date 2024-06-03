using StorageSystem.Dtos;
using StorageSystem.Models;
using System.Runtime.CompilerServices;

namespace StorageSystem.Mappers
{
    public static class StorageBinMapper
    {

        public static StorageBin ToStorageBin(this CreateStorageBinDTO storageBinDTO)
        {
            StorageBin storageBin = new StorageBin()
            {
                Location = storageBinDTO.LocationDto.ToLocation()
        };

            return storageBin;
        
        }
    }
}
