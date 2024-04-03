using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class UserReview
    {
        public int UserReviewID { get; set; }
        public byte UserNote { get; set; }
        public string? UserComment { get; set; }

        public int UserSenderID { get; set; }
        public User UserSender { get; set; }
        public int UserReceiverID { get; set; }
        public User UserReceiver { get; set; }
    }
}