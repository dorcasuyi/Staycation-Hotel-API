using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;


namespace StayCation.Hotel.Infrastructure.Repositories
{

    public class UserRepository :GenericRepository<User> , IUserRepository
    {
        public UserRepository(HotelDbContext _hotelDbContext): base(_hotelDbContext)
        {

        }
    }
}
