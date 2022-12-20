using AutoMapper;

using StayCation.Hotel.Core.DTO;
using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;


namespace StayCation.Hotel.Core.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        
        public UserServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
         
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="Password"></param>
        /// <returns>user</returns>

        public async Task<UserRegisterDto> GetUser(string Email, string Password)
        {
            var user = await _unitOfWork.UserRepository.GetAsync((x => x.Email == Email && x.Password == Password));
            return _mapper.Map<UserRegisterDto>(user);
        }

        /// <summary>
        /// get all users
        /// </summary>
        /// <returns>a list of the users</returns>

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            var users = await _unitOfWork.UserRepository.GetAllAsync();
            return users;
        }

        /// <summary>
        /// Register 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Void</returns>

        public async Task AddUser(UserRegisterDto user)
        {
            var users = _mapper.Map<User>(user);

            if (users == null)
            {
                Console.WriteLine("User DTO did not map to User: Invalid credentials provided for user registeration");
                throw new Exception("One or more of your inputs are incorrect");
            }
            
            users.Id = Guid.NewGuid().ToString();
            try
            {
                await _unitOfWork.UserRepository.AddAsync(users);
                await _unitOfWork.Save();
                Console.WriteLine($"User registration for {users.Email} was successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User details correct but could not add user to database: {ex.Message}");
                throw new Exception("One or more errors occured during your registration");
            }
          

        }

        /// <summary>
        /// Update user information
        /// </summary>
        /// <param name="user"></param>
        public async Task UpdateUser(string Id, UserRegisterDto user)
        {
            var users = await _unitOfWork.UserRepository.GetAsync(x => x.Id == Id);
            users.FirstName = user.FirstName;
            users.LastName = user.LastName;
            users.Email = user.Email;
            users.PhoneNumber = user.PhoneNumber;
            users.Password = user.Password;
            try
            {
                _unitOfWork.UserRepository.Update(users);
                await _unitOfWork.Save();
                Console.WriteLine($"Updated user {Id} information successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not update user {Id} information: {ex.Message}");
                throw new Exception("Could not update user information");
            }
        }
    }
}
