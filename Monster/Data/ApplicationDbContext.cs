using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Monster.Models;

namespace Monster.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Membership> Memberships { get; set; }

        protected ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
    }
}
