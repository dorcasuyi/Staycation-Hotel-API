using StayCation.Hotel.Core.DTO;

namespace StayCation.Hotel.Core.Interfaces
{
    public interface ILocationServices
    {
        Task CreateLocation(LocationDto location);
        Task DeleteLocationAsync(string id);
        Task<LocationDto> GetBookingByIdAsync(string id);
        Task<IEnumerable<LocationDto>> GetTAllLocationAsync();
    }
}