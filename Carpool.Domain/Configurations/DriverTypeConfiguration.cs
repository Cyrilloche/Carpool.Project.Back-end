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

            builder.HasKey(dt => dt.DriverTypeID);

            builder.Property(dt => dt.DriverTypeName).IsRequired().HasMaxLength(50);

            builder.HasData(
                new DriverType { DriverTypeID = 1, DriverTypeName = "Mamie au volant" },
                new DriverType { DriverTypeID = 2, DriverTypeName = "As du volant" }
            );
        }
    }
}