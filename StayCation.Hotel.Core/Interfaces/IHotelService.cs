using StayCation.Hotel.Core.DTO;

namespace StayCation.Hotel.Core.Interfaces
{
    public interface IHotelService
    {
        Task<List<HotelsDto>> GetAllHotelsAsync();
        Task<HotelDetailDto> GetHotelByIdAsync(string Id);
        Task AddHotelAsync(HotelDetailDto Hotel);
        Task DeleteHotelAsync(string Id);
        void UpDateHotel(HotelDetailDto Hotel);
    } 
}