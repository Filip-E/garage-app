using System.Collections.Generic;

namespace garage_app_entities
{
    public class Specification
    {
        public int Id { get; set; }

        public string Value { get; set; }
        public int SpecificationTypeId { get; set; }
        public SpecificationType SpecificationType { get; set; }

        public List<Product> Products { get; set; }

        public Specification()
        {
            Products = new List<Product>();
        }

        protected bool Equals(Specification other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Specification) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}