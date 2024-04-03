using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class Reward
    {
        public int RewardID { get; set; }
        public string RewardName { get; set; } = string.Empty;
        public string RewardPicture { get; set; } = string.Empty;

        public ICollection<UserReward> UserRewards { get; set; }
    }
}