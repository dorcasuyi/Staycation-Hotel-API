using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;



namespace StayCation.Hotel.Infrastructure.Repositories
{
    public class TransactionRepository :GenericRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(HotelDbContext _hotelDbContext): base(_hotelDbContext)
        {

        }
    }
}
