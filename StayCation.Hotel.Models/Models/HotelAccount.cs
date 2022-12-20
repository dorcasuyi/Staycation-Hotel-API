using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Models.Models
{
    public class HotelAccount
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string HotelsId { get; set; }
        public Hotels Hotels { get; set; }
    }
}
