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

        public List<Specification> Specifications { get; set; }

        public List<Image> Images { get; set; }
        public Product()
        {
            Categories = new List<Category>();
            Specifications = new List<Specification>();
            Images = new List<Image>();
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Price)}: {Price}, {nameof(Stock)}: {Stock}";
        }

        protected bool Equals(Product other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Product) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
