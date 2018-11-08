using System.Collections.Generic;

namespace garage_app_entities
{
    public class SpecificationType
    {
        public int Id { get; set; }

        public string Type { get; set; }
        public bool IsRequiredForCar { get; set; }

        public List<Specification> Specifications { get; set; }

        public SpecificationType()
        {
            Specifications = new List<Specification>();
        }

        protected bool Equals(SpecificationType other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((SpecificationType) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
