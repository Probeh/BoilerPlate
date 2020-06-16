using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected ApplicationContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.\\Data\\Application.db", options => options.MigrationsAssembly("WebAPI"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
