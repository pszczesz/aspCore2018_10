﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstCore.Data;

namespace MyFirstCore.Pages
{
    public class CreateModel : PageModel {
        private readonly AppDbContext _db;

        public CreateModel(AppDbContext db) {
            _db = db;
        }
        [BindProperty]
        [Required(ErrorMessage = "Podaj dane")]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _db.Customers.Add(Customer);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Index3");
        }
    }
}