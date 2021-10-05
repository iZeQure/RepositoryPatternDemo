using Demo.DbContexts;
using Demo.Generators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /* Items:
             * TODO: Create implementation for an aggregate root.
             * TODO: Create abstract Repository for the User.
             * TODO: Specify CRUD and User Specific operations.
             */

            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<XPowerDbContext>();

                ContextGenerator.InitializeDbContext(services);
            }

            var startup = ActivatorUtilities.GetServiceOrCreateInstance<Startup>(host.Services);

            await startup.StartDemoAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContext<XPowerDbContext>(options =>
                        options.UseInMemoryDatabase(databaseName: "XPowerDB"));
                });
    }
}
