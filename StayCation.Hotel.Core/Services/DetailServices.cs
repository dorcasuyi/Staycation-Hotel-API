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
    public class DetailServices : IDetailServices
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public DetailServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateDetailsAsync(DetailsDto detail)
        {
            var details = _mapper.Map<Detail>(detail);
            await unitOfWork.DetailsRepository.AddAsync(details);
            await unitOfWork.Save();
        }
        public async Task<IEnumerable<DetailsDto>> GetTAllDetailsAsync()
        {
            var details = await unitOfWork.DetailsRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<DetailsDto>>(details);

        }
        public async Task<DetailsDto> GetDetailsByIdAsync(string id)
        {
            var detail = await unitOfWork.DetailsRepository.GetAsync(x => x.Id == id);
            return _mapper.Map<DetailsDto>(detail);

        }
        public async Task DeleteAsync(string id)
        {
            await unitOfWork.DetailsRepository.DeleteAsync(id);
            await unitOfWork.Save();
        }
    }
}
