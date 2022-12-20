using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayCation.Hotel.Core.Interfaces;

namespace StayCation.Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;   
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHotelAsync()
        {
            var response = await _hotelService.GetAllHotelsAsync();
            return Ok(response);
        }

        [Route("{Id}")]
        [HttpGet] 
        public async Task <IActionResult> GetHotelByIdAsync(string Id)
        {
            var response = await _hotelService.GetHotelByIdAsync(Id);
            return Ok(response);
        }
    }
}
