using StayCation.Hotel.Core.DTO;
using StayCation.Hotel.Models.Models;

namespace StayCation.Hotel.Core.Interfaces
{
    public interface IUserServices
    {
        Task AddUser(UserRegisterDto user);
        Task<UserRegisterDto> GetUser(string Email, string Password);
        Task<IEnumerable<User>> GetUsersAsync();
        Task UpdateUser(string Id, UserRegisterDto user);
    }
}