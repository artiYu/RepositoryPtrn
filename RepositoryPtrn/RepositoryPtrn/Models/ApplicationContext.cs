using Microsoft.EntityFrameworkCore;

namespace RepositoryPtrn.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() { }
        public DbSet<Customer> Customers { get; set; }
    }
}
