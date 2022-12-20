using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Models.Models
{
    public class Location
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Hotels> Hotels { get; set; }

    }
}
