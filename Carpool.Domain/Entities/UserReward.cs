using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class UserReward
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int RewardID { get; set; }
        public Reward Reward { get; set; }

        public DateOnly UserRewardDate { get; set; }
    }
}