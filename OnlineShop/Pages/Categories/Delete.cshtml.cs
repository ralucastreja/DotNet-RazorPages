﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;

namespace OnlineShop.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly OnlineShop.Data.OnlineShopContext _context;

        public DeleteModel(OnlineShop.Data.OnlineShopContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FirstOrDefaultAsync(m => m.ID == id);

            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }
            var category = await _context.Categories.FindAsync(id);

            if (category != null)
            {
                Category = category;
                _context.Categories.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
