using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class FuelConfiguration : IEntityTypeConfiguration<Fuel>
    {
        public void Configure(EntityTypeBuilder<Fuel> builder)
        {
            builder.ToTable("Fuel");

            builder.HasKey(f => f.FuelID);

            builder.Property(f => f.FuelName).IsRequired().HasMaxLength(25);

            builder.HasData(
                new Fuel { FuelID = 1, FuelName = "Essence" },
                new Fuel { FuelID = 2, FuelName = "Diesel" },
                new Fuel { FuelID = 3, FuelName = "Hybride" },
                new Fuel { FuelID = 4, FuelName = "Électrique" }
            );
        }
    }
}