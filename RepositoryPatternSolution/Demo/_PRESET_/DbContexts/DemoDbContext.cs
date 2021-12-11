using Demo.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Demo._PRESET_.DbContexts
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
