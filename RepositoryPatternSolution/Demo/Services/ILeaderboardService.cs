using Demo.Models.Leaderboard;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Services
{
    public interface ILeaderboardService
    {
        public Task<IEnumerable<IScore>> GetScoresAsync();

        public Task<IScore> GetScoreById(Guid id);
    }
}
