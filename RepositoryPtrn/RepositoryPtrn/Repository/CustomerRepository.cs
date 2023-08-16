using Microsoft.EntityFrameworkCore;
using RepositoryPtrn.Models;

namespace RepositoryPtrn.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationContext context;

        public CustomerRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Customer> Get()
        {
            return context.Customers.ToList();
        }
        public Customer GetByID(int customerId)
        {
            return context.Customers.Find(customerId);
        }

        public void Insert(Customer customer)
        {
            context.Customers.Add(customer);
        }

        public void Delete(int customerId)
        {
            Customer customer = context.Customers.Find(customerId);
            context.Customers.Remove(customer);
        }

        public void Update(Customer customer)
        {
            context.Entry(customer).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
