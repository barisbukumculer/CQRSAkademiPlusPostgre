using Microsoft.EntityFrameworkCore;

namespace CQRSAkademiPlusPostgre.Dal
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
