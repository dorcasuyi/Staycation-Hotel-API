using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Models.Models
{
    public class Payment
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public decimal Tax { get; set; }
        public decimal SubPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string HotelAccountId { get; set; }
        public string BookingId { get; set; }
        public Booking Bookings { get; set; }
        public Transaction Transaction { get; set; }
    }
}
