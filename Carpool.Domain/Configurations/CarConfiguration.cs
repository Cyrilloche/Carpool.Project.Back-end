using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnType("int");
            builder.Property(c => c.Brand)
                .HasColumnType("varchar")
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(c => c.Model)
                .HasColumnType("varchar")
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(c => c.PaintColor)
                .HasColumnType("varchar")
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(c => c.Registration)
                .HasColumnType("varchar")
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(c => c.Picture)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.HasOne<User>(c => c.User)
            .WithOne(u => u.Car)
            .HasForeignKey<User>(c => c.Id);

            builder.HasOne<Fuel>(c => c.Fuel)
            .WithMany(f => f.Cars)
            .HasForeignKey(c => c.FuelID);

        }
    }
}