using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class UserRewardConfiguration : IEntityTypeConfiguration<UserReward>
    {
        public void Configure(EntityTypeBuilder<UserReward> builder)
        {
            builder.ToTable("user_reward");

            builder.HasKey(ur => new { ur.UserID, ur.RewardID });

            builder.Property(ur => ur.UserRewardDate).IsRequired();

            builder.HasOne<User>(ur => ur.User)
            .WithMany(u => u.UserRewards)
            .HasForeignKey(ur => ur.UserID);

            builder.HasOne<Reward>(ur => ur.Reward)
            .WithMany(r => r.UserRewards)
            .HasForeignKey(ur => ur.RewardID);
        }
    }
}