using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class UserReward
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int RewardId { get; set; }
        public Reward Reward { get; set; }

        public DateOnly UserRewardDate { get; set; }
    }
}