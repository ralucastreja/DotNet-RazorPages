using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Display(Name = "Product Name")]
        public string? Name { get; set; }
  
        public int Quantity { get; set; }

        public string? Supplier { get; set; }

        [Display(Name = "Product Category")]
        public string? Category { get; set;}
    }
}
