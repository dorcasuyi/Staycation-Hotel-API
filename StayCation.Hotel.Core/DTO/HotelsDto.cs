using StayCation.Hotel.Models.Models;

namespace StayCation.Hotel.Core.DTO
{
    public class HotelsDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsPopular { get; set; }
        public bool IsAvailable { get; set; }
        //Navigationss
        public Location Location { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
