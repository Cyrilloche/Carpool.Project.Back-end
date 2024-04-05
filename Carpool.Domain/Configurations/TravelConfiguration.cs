using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class TravelConfiguration : IEntityTypeConfiguration<Travel>
    {
        public void Configure(EntityTypeBuilder<Travel> builder)
        {
            builder.ToTable("travel");

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id)
                .HasColumnType("int");
            builder.Property(t => t.TimeDeparture)
                .HasColumnType("time")
                .IsRequired();
            builder.Property(t => t.DateDeparture)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(t => t.CreationDate)
                .HasColumnType("datetime")
                .IsRequired();
            builder.Property(t => t.AvailablePlace)
                .HasColumnType("tinyint")
                .IsRequired();

            builder.HasOne<User>(t => t.Publisher)
            .WithMany(p => p.Travels)
            .HasForeignKey(t => t.PublisherId);

            builder.HasOne<Adress>(t => t.GoingAdress)
            .WithMany(go => go.GoingTravel)
            .HasForeignKey(t => t.GoingAdressId);

            builder.HasOne<Adress>(t => t.ReturnAdress)
            .WithMany(rt => rt.ReturnTravel)
            .HasForeignKey(t => t.ReturnAdressId);
        }
    }
}