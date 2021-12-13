using Demo.Models.Leaderboard;
using Demo.Models.User;
using Demo.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    internal class Startup
    {
        private readonly IUserService _userService;
        private readonly ILeaderboardService _leaderboardService;
        private readonly ILogger<Startup> _logger;

        public Startup(IUserService userService, ILogger<Startup> logger, ILeaderboardService leaderboardService)
        {
            _userService = userService;
            _logger = logger;
            _leaderboardService = leaderboardService;
        }

        public async Task StartDemoAsync()
        {
            await LeaderboardDemo();

            await Task.Delay(-1);
        }

        private async Task LeaderboardDemo()
        {
            IEnumerable<IScore> leaderboard = await _leaderboardService.GetScoresAsync();
            IScore scoreById = await _leaderboardService.GetScoreById(leaderboard is not null || leaderboard.Any() ? leaderboard.Select(l => l.ClientID).FirstOrDefault() : Guid.NewGuid());

            if (leaderboard.Any())
            {
                _logger.LogInformation($"## Collection of Scores ##");
                _logger.LogInformation($"{"GUID",-36} | {"Score",-10} | {"Submitted Date",-20}");
                foreach (IScore score in leaderboard)
                {
                    _logger.LogInformation(string.Join(" | ", $"{score.ClientID,-36}", $"{decimal.Round(score.Value, 2),-10}", $"{score.SubmitDateTime.ToShortDateString(),-20}"));
                }
            }

            if (scoreById is not null)
            {
                _logger.LogInformation($"## Single Score by ID ##");
                _logger.LogInformation(string.Join(" | ", $"{scoreById.ClientID,-36}", $"{decimal.Round(scoreById.Value, 2),-10}", $"{scoreById.SubmitDateTime.ToShortDateString(),-20}"));
            }
        }

        private async Task UserDemo()
        {
            List<IUser> users = await _userService.GetUsersAsync();
            IUser userById = await _userService.GetUserById(3);

            if (users.Any())
            {
                _logger.LogInformation($"## Collection of Users ##");
                _logger.LogInformation($"{"ID",-5} | {"Username",-10} | {"Full Name",-10}");
                foreach (IUser user in users)
                {
                    _logger.LogInformation(string.Join(" | ", $"{user.Id,-5}", $"{user.Username,-10}", $"{user.FullName,-10}"));
                }
            }

            if (userById is not null)
            {
                _logger.LogInformation($"## Single User by ID ##");
                _logger.LogInformation(string.Join(" | ", $"{userById.Id,-5}", $"{userById.Username,-10}", $"{userById.FullName,-10}"));
            }
        }
    }
}
