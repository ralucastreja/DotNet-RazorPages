namespace OnlineShop.Models
{
    public class Product_Category //the JOIN entity
    {
        public  int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
