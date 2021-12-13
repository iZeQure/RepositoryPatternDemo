using Demo.Models.Leaderboard;
using Demo.Repositories.LeaderboardRepository.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class LeaderboardService : ILeaderboardService
    {
        private readonly ILeaderboardRepository _dbContext;
        private readonly ILogger<LeaderboardService> _logger;

        public LeaderboardService(ILeaderboardRepository dbContext, ILogger<LeaderboardService> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<IScore> GetScoreById(Guid id)
        {
            _logger.LogInformation($"## Retrieving data by using logic typeof [{_dbContext.GetType().Name}] ##");
            return await _dbContext.GetByIdAsync(id);
        }

        public async Task<IEnumerable<IScore>> GetScoresAsync()
        {
            _logger.LogInformation($"## Retrieving data by using logic typeof [{_dbContext.GetType().Name}] ##");
            return await _dbContext.GetAllAsync();
        }
    }
}
