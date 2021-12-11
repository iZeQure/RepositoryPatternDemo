using Demo.Models.User;
using Demo.Services;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo
{
    internal class Startup
    {
        private readonly IUserService _userService;
        private readonly ILogger<Startup> _logger;

        public Startup(IUserService userService, ILogger<Startup> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        public async Task StartDemoAsync()
        {
            List<IUser> users = await _userService.GetUsersAsync();
            IUser userById = await _userService.GetUserById(3);

            _logger.LogInformation($"{"ID", -5} | {"Username", -10} | {"Full Name", -10}");
            foreach (IUser user in users)
            {
                _logger.LogInformation(string.Join(" | ", $"{user.Id, -5}", $"{user.Username, -10}", $"{user.FullName, -10}"));
            }

            _logger.LogInformation(string.Join(" | ", $"{userById.Id,-5}", $"{userById.Username,-10}", $"{userById.FullName,-10}"));

            await Task.Delay(-1);
        }
    }
}
