using System.Collections.Generic;

namespace garage_app_entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public List<Category> Categories { get; set; }
        public Product()
        {
            Categories = new List<Category>();
        }
    }
}
