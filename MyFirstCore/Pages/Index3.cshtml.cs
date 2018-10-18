using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFirstCore.Data;

namespace MyFirstCore.Pages
{
    public class Index3Model : PageModel {
        private readonly AppDbContext _db;
        
        public Index3Model(AppDbContext db) {
            _db = db;
        }
        public IList<Customer> Customers { get; private set; }
        public async Task OnGetAsync() {
            Customers = await _db.Customers.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id) {
            var contact = await _db.Customers.FindAsync(id);
            if (contact != null) {
                _db.Customers.Remove(contact);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}