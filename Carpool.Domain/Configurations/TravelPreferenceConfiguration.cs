using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class TravelPreferenceConfiguration : IEntityTypeConfiguration<TravelPreference>
    {
        public void Configure(EntityTypeBuilder<TravelPreference> builder)
        {
            builder.ToTable("travelPreference");

            builder.HasKey(tp => tp.Id);
            builder.Property(tp => tp.Id)
                .HasColumnType("int");
            builder.Property(tp => tp.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}