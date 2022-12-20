using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;

namespace StayCation.Hotel.Infrastructure.Repositories
{
    public class CategoryRepository :GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(HotelDbContext _hotelDbContext): base(_hotelDbContext)
        {

        }
    }
}
