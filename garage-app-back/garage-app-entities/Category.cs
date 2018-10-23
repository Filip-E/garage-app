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

        protected bool Equals(Category other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Category) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
