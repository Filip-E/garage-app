using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(32)]
        public string Type { get; set; }

        public List<Product> Products { get; set; }
        public Category()
        {
            Products = new List<Product>();
        }
    }
}
