using Microsoft.EntityFrameworkCore;

namespace WebApplication1.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        { }
        public DbSet<Entities.Customer> tblCustomer { get; set; }

    }
}
