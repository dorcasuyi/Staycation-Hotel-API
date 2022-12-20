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
    public class CategoryServices : ICategoryServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddCategory(CategoryDto category)
        {
            var categorys = _mapper.Map<Category>(category);
            await _unitOfWork.CaterogryRepository.AddAsync(categorys);
            await _unitOfWork.Save();
        }
        public async Task DeleteCategory(string Id)
        {
            await _unitOfWork.CaterogryRepository.DeleteAsync(Id);
            await _unitOfWork.Save();
        }
    }
}
