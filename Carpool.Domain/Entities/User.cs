using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string UserLastname { get; set; } = string.Empty;
        public string UserFirstName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;
        public string UserPhoneNumber { get; set; } = string.Empty;

        // One-to-Many relationship
        public int StatusID { get; set; }
        public Status Status { get; set; }

        public int DriverTypeID { get; set; }
        public DriverType DriverType { get; set; }

        public Car Car { get; set; }



        // Many-to-many relationship
        public ICollection<UserTravelPreference> UserTravelPreferences { get; set; }
        public ICollection<UserReward> UserRewards { get; set; }
        public ICollection<UserNotification> UserNotifications { get; set; }
        public ICollection<UserReview> ReceivedUserReview { get; set; }
        public ICollection<UserReview> SentUserReview { get; set; }
        public ICollection<Message> SentUserMessage { get; set; }
        public ICollection<Message> ReceivedUserMessage { get; set; }



    }
}