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

            builder.HasKey(c => c.CarID);

            builder.Property(c => c.CarBrand).IsRequired().HasMaxLength(25);
            builder.Property(c => c.CarModel).IsRequired().HasMaxLength(25);
            builder.Property(c => c.CarPaintColor).IsRequired().HasMaxLength(25);
            builder.Property(c => c.CarRegistration).IsRequired().HasMaxLength(25);
            builder.Property(c => c.CarPicture).IsRequired().HasMaxLength(255);

            builder.HasOne<User>(c => c.User)
            .WithOne(u => u.Car)
            .HasForeignKey<User>(c => c.UserID);

            builder.HasOne<Fuel>(c => c.Fuel)
            .WithMany(f => f.Cars)
            .HasForeignKey(c => c.FuelID);

        }
    }
}