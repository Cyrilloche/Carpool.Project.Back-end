using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class DriverTypeConfiguration : IEntityTypeConfiguration<DriverType>
    {
        public void Configure(EntityTypeBuilder<DriverType> builder)
        {
            builder.ToTable("DriverType");

            builder.HasKey(dt => dt.Id);
            builder.Property(dt => dt.Id)
                .HasColumnType("int");
            builder.Property(dt => dt.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.HasData(
                new DriverType { Id = 1, Name = "Mamie au volant" },
                new DriverType { Id = 2, Name = "As du volant" }
            );
        }
    }
}