using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;

namespace StayCation.Hotel.Infrastructure.Repositories
{
    public class ImageRepository :GenericRepository<Image>, IImageRepository
    {
        public ImageRepository(HotelDbContext _hotelDbContext): base( _hotelDbContext)
        {

        }
       
    }
}
