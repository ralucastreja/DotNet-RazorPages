﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineShop.Data;
using OnlineShop.Models;

namespace OnlineShop.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly OnlineShop.Data.OnlineShopContext _context;

        public CreateModel(OnlineShop.Data.OnlineShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["Categories"] = new SelectList(_context.Set<Category >(), "ID", "Name");

            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
