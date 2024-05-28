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

        public static Location ToLocation(this LocationDTO locationDto)
        {

            Location location = new()
            {
                Name = locationDto.Name
            };

            return location;

        }

        public static LocationDTO ToLocationDTO(this Location location)
        {

            LocationDTO locationDTO = new()
            {
                Id = location.Id,
                Name = location.Name
            };

            return locationDTO;
        }
    }
}
