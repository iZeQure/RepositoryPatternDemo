using Demo._PRESET_.DbContexts;
using Demo._PRESET_.Generators;
using Demo.Models.Leaderboard;
using Demo.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Demo._PRESET_.Factories
{
    public class DbContextFactory
    {
        public static async Task CreateAsync(string name, string dataType, IServiceProvider provider)
        {
            switch (name, dataType)
            {
                case (nameof(DemoDbContext), nameof(IUser)):
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
                case (nameof(DemoDbContext), nameof(IScore)):
                    using (DemoDbContext context = new(provider.GetRequiredService<DbContextOptions<DemoDbContext>>()))
                    {
                        // Check if context is already populated.
                        if (await context.Leaderboard.AnyAsync())
                        {
                            // Exit the method early.
                            return;
                        }

                        await context.Leaderboard.AddRangeAsync(LeaderboardDataGenerator.GenerateLeaderboard());

                        await context.SaveChangesAsync();
                    }
                    break;
                default:
                    throw new ArgumentException("Something went wrong while creating context.");
            }
        }
    }
}
