using System.Collections.Generic;
using DAL;
using DAL.Repositories;
using garage_app_entities;

namespace garage_app_bl.Services
{
    public class ImageService
    {
        private readonly ImageRepository _imageRepository;
        private readonly ProductRepository _productRepository;

        public ImageService()
        {
            MyDbContext myDbContext = new MyDbContext();
            _imageRepository = new ImageRepository(myDbContext);
            _productRepository = new ProductRepository(myDbContext);
        }

        public void InsertImage(int productId, string filePath)
        {
            Image image = new Image
            {
                ProductId = productId,
                FilePath = filePath,
                Product = _productRepository.FindProduct(productId)
            };

            _imageRepository.InsertImage(image);
        }

        public List<Image> GetImagesByProduct(int productId)
        {
            _productRepository.FindProduct(productId);
           return _imageRepository.GetImagesByProductId(productId);
        }

        public void DeleteImage(int imageId)
        {
            _imageRepository.DeleteImage(imageId);
        }
    }
}
