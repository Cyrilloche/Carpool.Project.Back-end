using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class UserReviewConfiguration : IEntityTypeConfiguration<UserReview>
    {
        public void Configure(EntityTypeBuilder<UserReview> builder)
        {
            builder.ToTable("user_review");

            builder.HasKey(ur => ur.UserReviewID);

            builder.Property(ur => ur.UserNote).IsRequired();
            builder.Property(ur => ur.UserComment).HasMaxLength(1000);

            builder.HasOne<User>(ur => ur.UserSender)
            .WithMany(u => u.ReceivedUserReview)
            .HasForeignKey(ur => ur.UserSenderID);

            builder.HasOne<User>(ur => ur.UserReceiver)
            .WithMany(u => u.SentUserReview)
            .HasForeignKey(ur => ur.UserReceiverID);
        }
    }
}