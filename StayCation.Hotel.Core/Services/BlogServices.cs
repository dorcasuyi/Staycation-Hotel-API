using AutoMapper;
using StayCation.Hotel.Core.DTO;
using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;
using System;


namespace StayCation.Hotel.Core.Services
{
    public class BlogServices : IBlogServices
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public BlogServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateBlog(BlogDto blog)
        {
            var blogs = _mapper.Map<Blog>(blog);
            await unitOfWork.BlogRepository.AddAsync(blogs);
            await unitOfWork.Save();
        }
        public async Task<IEnumerable<BlogDto>> GetTAllBookingAsync()
        {
            var blogs = await unitOfWork.BlogRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<BlogDto>>(blogs);

        }
        public async Task<BlogDto> GetBookingByIdAsync(string id)
        {
            var blog = await unitOfWork.BlogRepository.GetAsync(x => x.Id == id);
            return _mapper.Map<BlogDto>(blog);

        }
        public async Task DeleteAsync(string id)
        {
            await unitOfWork.BlogRepository.DeleteAsync(id);
            await unitOfWork.Save();
        }
    }
}
