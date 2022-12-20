using AutoMapper;
using StayCation.Hotel.Core.DTO;
using StayCation.Hotel.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Core.Utilities
{
    public class HotelAutoMapper: Profile
    {
        public HotelAutoMapper()
        {
            CreateMap<BookingDto, Booking>().ReverseMap();
            CreateMap<HotelsDto, Hotels>().ReverseMap();
            CreateMap<HotelDetailDto, Hotels>().ReverseMap();
            CreateMap<TransactionDto, Transaction>().ReverseMap();
            CreateMap<UserRegisterDto, User>().ReverseMap();
            CreateMap<BlogDto, Blog>().ReverseMap();
            CreateMap<DetailsDto, Detail>().ReverseMap();
            CreateMap<LocationDto, Location>().ReverseMap();
        }
    }
}
