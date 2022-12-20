using StayCation.Hotel.Core.DTO;

namespace StayCation.Hotel.Core.Interfaces
{
    public interface IImageServices
    {
        Task<IEnumerable<ImageDto>> GetAllImagesAsync();
        Task<ImageDto> GetIsFeatureImages();
    }
}