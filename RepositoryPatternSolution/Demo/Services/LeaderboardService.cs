using Demo._PRESET_.DbContexts;
using Demo.Models.Leaderboard;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class LeaderboardService : ILeaderboardService
    {
        private readonly DemoDbContext _dbContext;

        public LeaderboardService(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IScore> GetScoreById(Guid id)
        {
            return await _dbContext.FindAsync<LeaderboardScore>(id);
        }

        public async Task<List<IScore>> GetScoresAsync()
        {
            return await _dbContext.Leaderboard.ToListAsync<IScore>();
        }
    }
}
