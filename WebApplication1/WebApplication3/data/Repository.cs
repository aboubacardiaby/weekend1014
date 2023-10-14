using WebApplication3.data.Entities;

namespace WebApplication3.data
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public void addnewCustomer(Customer customer)
        {
            _context.tblCustomer.Add(customer);
            _context.SaveChanges();
        }

        public void CreateDatabase()
        {
            _context.Database.EnsureCreated();
        }
    }
}
