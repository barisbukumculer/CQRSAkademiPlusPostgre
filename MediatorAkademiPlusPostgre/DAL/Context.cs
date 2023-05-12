using Microsoft.EntityFrameworkCore;

namespace MediatorAkademiPlusPostgre.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet <Category> Categories { get; set; }
        public DbSet<Product> Products { get; set;}
    }
}
