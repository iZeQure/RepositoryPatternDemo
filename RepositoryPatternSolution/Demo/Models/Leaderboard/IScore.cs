using System;

namespace Demo.Models.Leaderboard
{
    public interface IScore
    {
        public Guid ClientID { get; set; }
        public decimal Value { get; set; }
        public DateTime SubmitDateTime { get; set; }
    }
}
