using StayCation.Hotel.Core.DTO;

namespace StayCation.Hotel.Core.Interfaces
{
    public interface IBlogServices
    {
        Task CreateBlog(BlogDto blog);
        Task DeleteAsync(string id);
        Task<BlogDto> GetBookingByIdAsync(string id);
        Task<IEnumerable<BlogDto>> GetTAllBookingAsync();
    }
}