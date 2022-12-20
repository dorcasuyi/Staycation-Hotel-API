using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayCation.Hotel.Core.DTO;
using StayCation.Hotel.Core.Interfaces;

namespace StayCation.Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
        [Route("CreateAUser")]
        [HttpPost]
        public async Task <IActionResult> RegisterAUser(UserRegisterDto register)
        {
            await _userServices.AddUser(register);
            return Ok(register);
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        [Route("{Id}")]
        [HttpGet]
        public async Task <IActionResult> LoginAUser(string Email, string Password)
        {
          var response = await _userServices.GetUser(Email, Password);
            return Ok(response);
        }

        [HttpGet]
        public async Task <IActionResult> GetAllUsers()
        {
            var response = await _userServices.GetUsersAsync();
            return Ok(response);
        }

        [HttpPost]
        [Route("UpdateAUser/{Id}")]
        public async Task <IActionResult> UpdateAUser(string Id, UserRegisterDto register)
        {
            await _userServices.UpdateUser(Id, register);
            return Ok(register);
        }
    }
}
