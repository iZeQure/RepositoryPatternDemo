using Demo.DbContexts;
using Demo.Repositories.UserRepository.Abstractions;
using System.Threading.Tasks;

namespace Demo
{
    internal class Startup
    {
        //private readonly XPowerDbContext _context;
        private readonly IUserRepository _userRepository;

        public Startup(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task StartDemoAsync()
        {
            foreach (var item in _userRepository.GetAll())
            {
                System.Console.WriteLine(item.FullName);
            }

            await Task.Delay(-1);
        }
    }
}
