using Demo.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Generators
{
    public class ContextGenerator
    {
        public static void InitializeUserContext(IServiceProvider serviceProvider)
        {
            using (var context = new XPowerDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<XPowerDbContext>>()))
            {
                // Check if context is already populated.
                if (context.Users.Any())
                {
                    // Exit the method early.
                    return;
                }

                context.Users.AddRange(UserDataGenerator.GenerateUsers());

                context.SaveChanges();
            }
        }
    }
}
