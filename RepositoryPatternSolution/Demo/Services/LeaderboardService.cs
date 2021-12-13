using Demo._PRESET_.DbContexts;
using Demo.Models.Leaderboard;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class LeaderboardService : ILeaderboardService
    {
        private readonly DemoDbContext _dbContext;
        private readonly ILogger<LeaderboardService> _logger;

        private readonly string _dbContextTypeName;

        public LeaderboardService(DemoDbContext dbContext, ILogger<LeaderboardService> logger)
        {
            _dbContext = dbContext;
            _logger = logger;

            _dbContextTypeName = _dbContext.GetType().FullName;
        }

        public async Task<IScore> GetScoreById(Guid id)
        {
            _logger.LogInformation($"## Retrieving data by using logic typeof [{_dbContextTypeName}] ##");
            return await _dbContext.FindAsync<LeaderboardScore>(id);
        }

        public async Task<IEnumerable<IScore>> GetScoresAsync()
        {
            _logger.LogInformation($"## Retrieving data by using logic typeof [{_dbContextTypeName}] ##");
            return await _dbContext.Leaderboard.ToListAsync<IScore>();
        }
    }
}
