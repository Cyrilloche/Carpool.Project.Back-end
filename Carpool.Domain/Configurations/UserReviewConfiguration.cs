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

            builder.HasKey(ur => ur.Id);
            builder.Property(ur => ur.Id)
                .HasColumnType("int");
            builder.Property(ur => ur.Note)
                .HasColumnType("tinyint")
                .IsRequired();
            builder.Property(ur => ur.Comment)
                .HasColumnType("text");

            builder.HasOne<User>(ur => ur.UserSender)
            .WithMany(u => u.ReceivedUserReview)
            .HasForeignKey(ur => ur.UserSenderId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<User>(ur => ur.UserReceiver)
            .WithMany(u => u.SentUserReview)
            .HasForeignKey(ur => ur.UserReceiverId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}