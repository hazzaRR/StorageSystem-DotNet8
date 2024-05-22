using StorageSystem.Dtos;
using StorageSystem.Models;

namespace StorageSystem.Mappers
{
    public static class LocationMapper
    {

        public static Location ToLocation(this CreateLocationDTO locationDto)
        {

            Location location = new()
            {
                Name = locationDto.Name
            };

            return location;

        }
    }
}
