using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;



namespace StayCation.Hotel.Infrastructure.Repositories
{
    public class PaymentRepository :GenericRepository<Payment> , IPaymentRepository
    {
        public PaymentRepository(HotelDbContext _hotelDbContext): base(_hotelDbContext)
        {

        }
    }
}
