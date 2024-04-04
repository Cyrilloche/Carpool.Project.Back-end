using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class UserNotificationConfiguration : IEntityTypeConfiguration<UserNotification>
    {
        public void Configure(EntityTypeBuilder<UserNotification> builder)
        {
            builder.ToTable("user_notification");

            builder.HasKey(un => new { un.UserId, un.NotificationId });

            builder.HasOne<User>(un => un.User)
            .WithMany(u => u.UserNotifications)
            .HasForeignKey(un => un.UserId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Notification>(un => un.Notification)
            .WithMany(n => n.UserNotifications)
            .OnDelete(DeleteBehavior.Cascade)
            .HasForeignKey(un => un.NotificationId);
        }
    }
}