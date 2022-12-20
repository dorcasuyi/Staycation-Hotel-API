using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayCation.Hotel.Core.DTO;
using StayCation.Hotel.Core.Interfaces;

namespace StayCation.Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailsController : ControllerBase
    {
        private readonly IDetailServices _detialsService;

        public DetailsController(IDetailServices detailServices)
        {
            _detialsService = detailServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDetails()
        {
            var response = await _detialsService.GetTAllDetailsAsync();
            return Ok(response);
        }
        [Route("{Id}")]
        [HttpGet]
        public async Task <IActionResult> GetDetailById(string Id)
        {
            var response = await _detialsService.GetDetailsByIdAsync(Id);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDetail(DetailsDto details)
        {

            await _detialsService.CreateDetailsAsync(details);
            return Ok(details);

        }
    }
}
