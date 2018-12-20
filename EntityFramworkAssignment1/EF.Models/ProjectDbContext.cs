using System.Data.Entity;

namespace EF.Models
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext():base("ProjectDbContext")
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
    }
}