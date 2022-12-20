using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Infrastructure.Repositories
{
    public class LocationRepository :GenericRepository<Location> , ILocationRepository
    {
        public LocationRepository(HotelDbContext _hotelDbContext): base(_hotelDbContext)
        {

        }
    }
}
