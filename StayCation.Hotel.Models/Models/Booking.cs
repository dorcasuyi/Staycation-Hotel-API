using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Models.Models
{
    public class Booking
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public decimal Price { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PaymentImageUpload { get; set; }
        //Navigation
        public string UserId { get; set; }
        public User User { get; set; }
        public string HotelsId { get; set; }
        public Hotels Hotels { get; set; }
        public Payment Payment { get; set; }
    }
}
