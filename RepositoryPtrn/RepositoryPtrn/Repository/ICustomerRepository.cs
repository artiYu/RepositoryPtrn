using System.Collections;
using RepositoryPtrn.Models;

namespace RepositoryPtrn.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable Get();
        Customer GetByID(int customerId);
        void Insert(Customer customer);
        void Delete(int customerId);
        void Update(Customer customer);
        void Save();
    }
}
