using AutoMapper;
using StayCation.Hotel.Core.DTO;
using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models; 

namespace StayCation.Hotel.Core.Services
{
    public class HotelService : IHotelService
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _mapper;
        public HotelService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<HotelsDto>> GetAllHotelsAsync()
        {
            var GetAllHotelDto = await _UnitOfWork.HotelsRepository.GetAllAsync();

            return _mapper.Map<List<HotelsDto>>(GetAllHotelDto);
        }
        //gets a hotel by a specific id
        public async Task<HotelDetailDto> GetHotelByIdAsync(string Id)
        {
            var GetHotelDto = await _UnitOfWork.HotelsRepository.GetAsync(x => x.Id == Id);
            return _mapper.Map<HotelDetailDto>(GetHotelDto);
        }
        public async Task AddHotelAsync(HotelDetailDto Hotel)
        {
            var AddHotel = _mapper.Map<Hotels>(Hotel);
            await _UnitOfWork.HotelsRepository.AddAsync(AddHotel);
            await _UnitOfWork.Save();
        }
        public async Task DeleteHotelAsync(string Id)
        {
            await _UnitOfWork.HotelsRepository.DeleteAsync(Id);
        }
        public void UpDateHotel(HotelDetailDto Hotel)
        {
            var UpdateHotel = _mapper.Map<Hotels>(Hotel);
            _UnitOfWork.HotelsRepository.Update(UpdateHotel);
            _UnitOfWork.Save();
        }
    }
}
