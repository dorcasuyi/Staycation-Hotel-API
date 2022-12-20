using StayCation.Hotel.Models.Models;

namespace StayCation.Hotel.Core.Interfaces
{
    public interface IHotelRepository: IGenericRepository<Hotels>
    {
        //Task<IEnumerable<Hotels>> GetAllHotelsAsync();
        //Task<Hotels> GetHotelById(string Id);
        //Task AddHotelAsync(Hotels Hotel);
        //Task DeleteHotelAsync(string Id);
        //void UpDateHotel(Hotels Hotel);       
    }
}