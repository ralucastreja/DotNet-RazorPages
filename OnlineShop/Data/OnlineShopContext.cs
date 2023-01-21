using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Data
{
    public class OnlineShopContext : DbContext
    {
        public OnlineShopContext (DbContextOptions<OnlineShopContext> options)  : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product_Category>()
                    .HasOne(p => p.Product)
                    .WithMany(pc => pc.Product_Categories)
                    .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<Product_Category>()
                    .HasOne(c => c.Category)
                    .WithMany(pc => pc.Product_Categories)
                    .HasForeignKey(ci => ci.CategoryId);
        }
        public DbSet<Product> Product { get; set; } = default!;

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product_Category> Products_Categories { get; set; }
    }
}
