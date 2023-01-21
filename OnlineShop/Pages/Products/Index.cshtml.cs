using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly OnlineShop.Data.OnlineShopContext _context;

        public IndexModel(OnlineShop.Data.OnlineShopContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                Product = await _context.Product
                    .Include(pc => pc.Product_Categories)
                    .ToListAsync();
            }
        }
    }
}
