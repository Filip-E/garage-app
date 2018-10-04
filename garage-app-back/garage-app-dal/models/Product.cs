using DAL.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }

        public List<Category> Categories { get; set; }
        public Product()
        {
            Categories = new List<Category>();
        }
    }
}
