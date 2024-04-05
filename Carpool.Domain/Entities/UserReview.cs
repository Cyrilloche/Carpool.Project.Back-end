using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class UserReview
    {
        public int Id { get; set; }
        public int Note { get; set; }
        public string? Comment { get; set; }

        public int UserSenderId { get; set; }
        public User UserSender { get; set; }
        public int UserReceiverId { get; set; }
        public User UserReceiver { get; set; }
    }
}