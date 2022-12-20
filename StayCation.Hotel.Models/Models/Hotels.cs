using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Models.Models
{
    public class Hotels
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsPopular { get; set; }
        public bool IsAvailable { get; set; }
        public string LocationId { get; set; }
        //Navigationss
        public Location Location { get; set; }
        public Detail Details { get; set; }
        public Booking Bookings { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<HotelAccount> HotelAccounts { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
