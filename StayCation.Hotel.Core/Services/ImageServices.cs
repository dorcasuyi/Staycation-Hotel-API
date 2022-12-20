using AutoMapper;
using StayCation.Hotel.Core.DTO;
using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;

namespace StayCation.Hotel.Core.Services
{
    public class ImageServices : IImageServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ImageServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ImageDto>> GetAllImagesAsync()
        {
            var images = await _unitOfWork.ImageRepository.GetAllAsync();

            return _mapper.Map<List<ImageDto>>(images);
        }

        public async Task<ImageDto> GetIsFeatureImages()
        {
            var image = await _unitOfWork.ImageRepository.GetAsync(x => x.IsFeature == true);
            return _mapper.Map<ImageDto>(image);

        }
        public async Task AddImageAsync(ImageDto images)
        {
         var image = _mapper.Map<Image>(images);
            await _unitOfWork.ImageRepository.AddAsync(image);
            await _unitOfWork.Save();
        }

        public  void UpdateImages(ImageDto images)
        {
            var image = _mapper.Map<Image>(images);
             _unitOfWork.ImageRepository.Update(image);
            _unitOfWork.Save();
        }

        public async Task DeleteImage(string Id)
        {
            await _unitOfWork.ImageRepository.DeleteAsync(Id);
            await _unitOfWork.Save();
        }
    }
}
