using Demo.Models.Leaderboard;
using System;
using System.Collections.Generic;

namespace Demo._PRESET_.Generators
{
    internal static class LeaderboardDataGenerator
    {
        private readonly static Random _rnd = new();
        private const int _iterations = 10;
        private const int _minScore = 1;
        private const int _maxScore = 3000;

        internal static List<LeaderboardScore> GenerateLeaderboard()
        {
            return Data();
        }

        private static List<LeaderboardScore> Data()
        {
            List<LeaderboardScore> leaderboard = new();

            for (int i = 0; i < _iterations; i++)
            {
                decimal rndScore = _minScore + ((decimal)_rnd.NextDouble() * (_maxScore - _minScore));

                LeaderboardScore score = new() { 
                    ClientID = Guid.NewGuid(), 
                    SubmitDateTime = DateTime.Now, 
                    Value = rndScore 
                };

                leaderboard.Add(score);
            }

            return leaderboard;
        }
    }
}
