using StayCation.Hotel.Core.DTO;

namespace StayCation.Hotel.Core.Interfaces
{
    public interface IBookingService
    {
        Task CreateBooking(BookingDto booking);
        Task DeleteAsync(string id);
        Task<BookingDto> GetBookingByIdAsync(string id);
        Task<IEnumerable<BookingDto>> GetTAllBookingAsync();
    }
}