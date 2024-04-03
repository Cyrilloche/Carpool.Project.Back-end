using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class UserReservationConfiguration : IEntityTypeConfiguration<UserReservation>
    {
        public void Configure(EntityTypeBuilder<UserReservation> builder)
        {
            builder.ToTable("user_reservation");

            builder.HasKey(ur => new { ur.PassengerID, ur.TravelID });

            builder.Property(ur => ur.ReservationDate).IsRequired();
            builder.Property(ur => ur.ResponseDate).IsRequired();
            builder.Property(ur => ur.Acceptation).IsRequired();

            builder.HasOne<User>(ur => ur.Passenger)
            .WithMany(p => p.UserReservations)
            .HasForeignKey(ur => ur.PassengerID);

            builder.HasOne<Travel>(ur => ur.Travel)
            .WithMany(t => t.UserReservations)
            .HasForeignKey(ur => ur.TravelID);
        }
    }
}