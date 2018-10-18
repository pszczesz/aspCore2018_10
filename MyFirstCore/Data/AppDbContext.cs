using Microsoft.EntityFrameworkCore;

namespace MyFirstCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            :base(options) {
            //Customers.Add(new Customer() {Name = "Pierwszy"});
            //Customers.Add(new Customer() { Name = "Drugi" });
            //Customers.Add(new Customer() { Name = "Trzeci" });
            //Customers.Add(new Customer() { Name = "Czwarty" });
        }
        public  DbSet<Customer> Customers { get; set; }

        
    }
}