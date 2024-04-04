using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class UserTravelPreferenceConfiguration : IEntityTypeConfiguration<UserTravelPreference>
    {
        public void Configure(EntityTypeBuilder<UserTravelPreference> builder)
        {
            builder.ToTable("UserTravelPreference");

            builder.HasKey(utp => new { utp.UserId, utp.TravelPreferenceId });

            builder.HasOne<User>(utp => utp.User)
            .WithMany(u => u.UserTravelPreferences)
            .HasForeignKey(utp => utp.UserId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<TravelPreference>(utp => utp.TravelPreference)
            .WithMany(tp => tp.UserTravelPreferences)
            .HasForeignKey(utp => utp.TravelPreferenceId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}