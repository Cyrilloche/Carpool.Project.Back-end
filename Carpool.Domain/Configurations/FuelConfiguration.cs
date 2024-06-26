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
            builder.ToTable("fuel");

            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id)
                .HasColumnType("int");
            builder.Property(f => f.Name)
                .HasColumnType("varchar")
                .HasMaxLength(25)
                .IsRequired();

            builder.HasData(
                new Fuel { Id = 1, Name = "Essence" },
                new Fuel { Id = 2, Name = "Diesel" },
                new Fuel { Id = 3, Name = "Hybride" },
                new Fuel { Id = 4, Name = "Électrique" }
            );
        }
    }
}