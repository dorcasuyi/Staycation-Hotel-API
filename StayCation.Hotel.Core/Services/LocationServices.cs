using AutoMapper;
using StayCation.Hotel.Core.DTO;
using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Core.Services
{
    public class LocationServices : ILocationServices
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public LocationServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateLocation(LocationDto location)
        {
            var locations = _mapper.Map<Location>(location);
            await unitOfWork.LocationRepository.AddAsync(locations);
            await unitOfWork.Save();
        }
        public async Task<IEnumerable<LocationDto>> GetTAllLocationAsync()
        {
            var blogs = await unitOfWork.LocationRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<LocationDto>>(blogs);

        }
        public async Task<LocationDto> GetBookingByIdAsync(string id)
        {
            var location = await unitOfWork.LocationRepository.GetAsync(x=> x.Id == id);
            return _mapper.Map<LocationDto>(location);

        }
        public async Task DeleteLocationAsync(string id)
        {
            await unitOfWork.LocationRepository.DeleteAsync(id);
            await unitOfWork.Save();
        }
    }
}
