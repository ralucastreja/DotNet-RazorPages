using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a category name")]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Categories")]
        public List<Product_Category> Product_Categories { get; set; } //navigation property
    }
}
