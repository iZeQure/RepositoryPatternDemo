using Demo.Models.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DbContexts
{
    public class XPowerDbContext : DbContext
    {
        public XPowerDbContext(DbContextOptions<XPowerDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
