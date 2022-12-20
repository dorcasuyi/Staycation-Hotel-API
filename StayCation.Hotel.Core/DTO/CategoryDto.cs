using StayCation.Hotel.Models.Models;


namespace StayCation.Hotel.Core.DTO
{
    public class CategoryDto
    {
        public string Name { get; set; }
        public ICollection<Hotels> Hotels { get; set; }
    }
}
