using Demo._PRESET_.DbContexts;
using Demo.Models.Leaderboard;
using Demo.Repositories.LeaderboardRepository.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Repositories.LeaderboardRepository
{
    public class DbLeaderboardRepository : ILeaderboardRepository
    {
        private readonly DemoDbContext _demoDbContext;

        public DbLeaderboardRepository(DemoDbContext demoDbContext)
        {
            _demoDbContext = demoDbContext;
        }

        public async Task<IEnumerable<IScore>> GetAllAsync()
        {
            return await _demoDbContext.Leaderboard.ToListAsync<IScore>();
        }

        public async Task<IScore> GetByIdAsync(Guid id)
        {
            return await _demoDbContext.Leaderboard.FindAsync(id);
        }
    }
}
