using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Lastname { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;


        // One-to-Many relationship
        public int StatusId { get; set; }
        public Status Status { get; set; }

        public int DriverTypeId { get; set; }
        public DriverType DriverType { get; set; }

        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }

        // One-to-one relationship
        public Car Car { get; set; }

        // Many-to-many relationship
        public ICollection<UserTravelPreference> UserTravelPreferences { get; set; }
        public ICollection<UserReward> UserRewards { get; set; }
        public ICollection<UserNotification> UserNotifications { get; set; }
        public ICollection<UserReservation> UserReservations { get; set; }


        // Many-to-One relationship
        public ICollection<UserReview> ReceivedUserReview { get; set; }
        public ICollection<UserReview> SentUserReview { get; set; }
        public ICollection<Message> SentUserMessage { get; set; }
        public ICollection<Message> ReceivedUserMessage { get; set; }
        public ICollection<Travel> Travels { get; set; }



    }
}