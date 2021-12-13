using Demo.Models.Leaderboard;
using System;

namespace Demo.Repositories.LeaderboardRepository.Abstractions
{
    public interface ILeaderboardRepository : IReadOnlyRepository<IScore, Guid> { }
}
