using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Models.Models
{
    public class Blog
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Experience { get; set; }
        public byte Ratings { get; set; }
        public string Titles { get; set; }
        public string UserId { get; set; }
        public User user { get; set; }
    }
}
