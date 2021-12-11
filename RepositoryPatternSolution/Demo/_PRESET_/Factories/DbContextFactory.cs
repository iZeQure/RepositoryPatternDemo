using Demo._PRESET_.DbContexts;
using Demo._PRESET_.Generators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Demo._PRESET_.Factories
{
    public class DbContextFactory
    {
        public static async Task CreateAsync(string name, IServiceProvider provider)
        {
            switch (name)
            {
                case nameof(DemoDbContext):
                    using (DemoDbContext context = new(provider.GetRequiredService<DbContextOptions<DemoDbContext>>()))
                    {
                        // Check if context is already populated.
                        if (await context.Users.AnyAsync())
                        {
                            // Exit the method early.
                            return;
                        }

                        await context.Users.AddRangeAsync(UserDataGenerator.GenerateUsers());

                        await context.SaveChangesAsync();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
