using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a product name")] //data adnotations
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the quantity")]
        public int Quantity { get; set; }

        public string? Supplier { get; set; }

        [Display(Name = "Categories")]
        public List<Product_Category> Product_Categories { get; set; } //navigation property
    }
}
