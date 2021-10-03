using Demo.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Demo.DbContexts
{
    public class XPowerDbContext : DbContext
    {
        public XPowerDbContext(DbContextOptions<XPowerDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
