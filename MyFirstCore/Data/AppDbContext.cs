using Microsoft.EntityFrameworkCore;

namespace MyFirstCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            :base(options)
        {
            
        }
        public  DbSet<Customer> Customers { get; set; }
    }
}