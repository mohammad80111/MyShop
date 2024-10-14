using Microsoft.EntityFrameworkCore;

namespace MyShop.Models
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }


        public DbSet<Car> Cars { get; set; }    
        public DbSet<Service> Services { get; set; }
        public DbSet<CarSize> Sizes { get; set; }   
    }
}
