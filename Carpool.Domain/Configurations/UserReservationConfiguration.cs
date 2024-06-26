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

            builder.HasKey(ur => new { ur.PassengerId, ur.TravelId });

            builder.Property(ur => ur.ReservationDate)
                .HasColumnType("datetime")
                .IsRequired();
            builder.Property(ur => ur.ResponseDate)
                .HasColumnType("datetime")
                .IsRequired();
            builder.Property(ur => ur.Acceptation)
                .HasColumnType("tinyint(1)")
                .IsRequired();

            builder.HasOne<User>(ur => ur.Passenger)
            .WithMany(p => p.UserReservations)
            .HasForeignKey(ur => ur.PassengerId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Travel>(ur => ur.Travel)
            .WithMany(t => t.UserReservations)
            .HasForeignKey(ur => ur.TravelId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}