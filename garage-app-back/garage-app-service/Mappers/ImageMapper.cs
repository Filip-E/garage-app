using garage_app_entities;
using garage_app_service.DTOs.Response;

namespace garage_app_service.Mappers
{
    public class ImageMapper
    {
        public ImageResponseDto ToDto(Image image)
        {
            return new ImageResponseDto()
            {
                imageId = image.Id,
                filePath = image.FilePath
            };
        }
    }
}