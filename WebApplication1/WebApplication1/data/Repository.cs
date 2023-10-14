namespace WebApplication1.data
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Createdatabase()
        {
            _context.Database.EnsureCreated();
        }

    }
}
