using System.Collections.Generic;

namespace garage_app_entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public List<Product> Products { get; set; }
        public Category()
        {
            Products = new List<Product>();
        }
    }
}
