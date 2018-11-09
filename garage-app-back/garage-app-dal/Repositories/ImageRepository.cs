using System.Collections.Generic;
using System.Linq;
using garage_app_entities;
using MySql.Data.MySqlClient;

namespace DAL.Repositories
{
    public class ImageRepository
    {

        private readonly MyDbContext _context;

        public ImageRepository(MyDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// adds a new image to the DB and adds it to the corresponding product
        /// </summary>
        /// <param name="image"></param>
        public void InsertImage(Image image)
        {
            _context.Images.Add(image);
            _context.Products.Attach(image.Product);
            image.Product.Images.Add(image);
            _context.SaveChanges();
        }
        /// <summary>
        /// get the images from the product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public List<Image> GetImagesByProductId(int productId)
        {
            return _context.Images.SqlQuery("SELECT * FROM garagedb.images WHERE ProductId = productId",new MySqlParameter("productId",productId)).ToList();
//            return _context.Images.Where(image => image.ProductId == productId).ToList();
        }
        /// <summary>
        /// deletes a image from the db and from the corresponding product list
        /// </summary>
        /// <param name="imageId"></param>
        public void DeleteImage(int imageId)
        {
            Image findImage = _context.Images.Include("Product").First(image => image.Id == imageId );
            _context.Products.Attach(findImage.Product);
            findImage.Product.Images.Remove(findImage);
            _context.Images.Remove(findImage);
            _context.SaveChanges();
        }
    }
}