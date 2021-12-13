using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Demo._PRESET_;
using Demo._PRESET_.DbContexts;
using Demo._PRESET_.Factories;
using Demo.Services;
using Demo.Models.Leaderboard;

namespace Demo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<DemoDbContext>();

                await DbContextFactory.CreateAsync(nameof(DemoDbContext), nameof(IScore), services);
            }

            var startup = ActivatorUtilities.GetServiceOrCreateInstance<Startup>(host.Services);

            await startup.StartDemoAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(app =>
                {
                    app.AddUserSecrets<Program>();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    var demoSettings = hostContext.Configuration.GetSection("DemoSettings").Get<DbContextSettings>();

                    services.AddDbContext<DemoDbContext>(options =>
                        options.UseInMemoryDatabase(databaseName: demoSettings.DbContextName));

                    services.AddSingleton<IUserService, UserService>();
                    services.AddSingleton<ILeaderboardService, LeaderboardService>();
                });
    }
}
