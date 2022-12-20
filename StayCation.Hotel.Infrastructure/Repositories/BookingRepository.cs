using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;


namespace StayCation.Hotel.Infrastructure.Repositories
{
    public class BookingRepository :GenericRepository<Booking> , IBookingRepository
    {
        public BookingRepository(HotelDbContext _hotelDbContext): base(_hotelDbContext)
        {

        }
    }

}