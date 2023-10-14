using WebApplication3.data.Entities;

namespace WebApplication3.data
{
    public interface IRepository
    {

        void CreateDatabase();

        void addnewCustomer(Customer customer);
    }
}
