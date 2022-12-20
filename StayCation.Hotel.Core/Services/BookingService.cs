using AutoMapper;
using StayCation.Hotel.Core.DTO;
using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;

namespace StayCation.Hotel.Core.Services
{
    public class BookingService : IBookingService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public BookingService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateBooking(BookingDto booking)
        {
            var bookings = _mapper.Map<Booking>(booking);
            await unitOfWork.BookingRepository.AddAsync(bookings);
            await unitOfWork.Save();
        }
        public async Task<IEnumerable<BookingDto>> GetTAllBookingAsync()
        {
            var booKings = await unitOfWork.BookingRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<BookingDto>>(booKings);

        }
        public async Task<BookingDto> GetBookingByIdAsync(string id)
        {
            var booking = await unitOfWork.BookingRepository.GetAsync(x => x.Id == id);
            return _mapper.Map<BookingDto>(booking);

        }
        public async Task DeleteAsync(string id)
        {
            await unitOfWork.BookingRepository.DeleteAsync(id);
            await unitOfWork.Save();
        }
    }








}
