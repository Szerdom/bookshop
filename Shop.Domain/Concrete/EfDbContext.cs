using Shop.Domain.Entities;
using System.Data.Entity;

namespace Shop.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
