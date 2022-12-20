using StayCation.Hotel.Core.DTO;

namespace StayCation.Hotel.Core.Interfaces
{
    public interface IDetailServices
    {
        Task CreateDetailsAsync(DetailsDto detail);
        Task DeleteAsync(string id);
        Task<DetailsDto> GetDetailsByIdAsync(string id);
        Task<IEnumerable<DetailsDto>> GetTAllDetailsAsync();
    }
}