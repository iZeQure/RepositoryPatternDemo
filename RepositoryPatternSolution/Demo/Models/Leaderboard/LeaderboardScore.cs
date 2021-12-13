using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models.Leaderboard
{
    public class LeaderboardScore : IScore
    {
        [Key]
        public Guid ClientID { get; set; }
        public decimal Value { get; set; }
        public DateTime SubmitDateTime { get; set; }
    }
}
