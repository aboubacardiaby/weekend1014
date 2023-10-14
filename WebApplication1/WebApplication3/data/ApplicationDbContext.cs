using Microsoft.EntityFrameworkCore;
using WebApplication3.data.Entities;

namespace WebApplication3.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Customer> tblCustomer { get; set; }
    }
}
