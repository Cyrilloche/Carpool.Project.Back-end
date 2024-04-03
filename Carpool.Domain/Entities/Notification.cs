using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public string NotificationName { get; set; } = string.Empty;

        public ICollection<UserNotification> UserNotifications { get; set; }
    }
}