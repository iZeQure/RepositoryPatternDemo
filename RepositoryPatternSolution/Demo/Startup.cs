using Demo.DbContexts;
using System.Threading.Tasks;

namespace Demo
{
    internal class Startup
    {
        private readonly XPowerDbContext _context;

        public Startup(XPowerDbContext context)
        {
            _context = context;
        }

        public async Task StartDemoAsync()
        {
            foreach (var item in _context.Users)
            {
                System.Console.WriteLine(item.FullName);
            }

            await Task.Delay(-1);
        }
    }
}
