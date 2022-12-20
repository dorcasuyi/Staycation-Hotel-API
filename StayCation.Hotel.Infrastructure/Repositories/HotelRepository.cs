using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;

 
namespace StayCation.Hotel.Infrastructure.Repositories
{
    public class HotelRepository : GenericRepository<Hotels>, IHotelRepository
    {
        public HotelRepository(HotelDbContext dbContext):base(dbContext)
        {

        }
   
    }
}
