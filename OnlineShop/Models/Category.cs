using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a category name")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        public ICollection<Product>? Products { get; set; } //navigation property
    }
}
