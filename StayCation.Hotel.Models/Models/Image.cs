using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Models.Models
{
    public class Image
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string ImageUrl { get; set; }
        public bool IsFeature { get; set; }
        public Hotels Hotels { get; set; }
        public string HotelsId { get; set; }
    }
}
