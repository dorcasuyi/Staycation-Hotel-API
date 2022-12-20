using StayCation.Hotel.Core.DTO;

namespace StayCation.Hotel.Core.Interfaces
{
    public interface ICategoryServices
    {
        Task AddCategory(CategoryDto category);
        Task DeleteCategory(string Id);
    }
}