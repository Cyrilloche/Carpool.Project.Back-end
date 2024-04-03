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
            builder.ToTable("TravelPreference");

            builder.HasKey(tp => tp.TravelPreferenceID);

            builder.Property(tp => tp.TravelPreferenceName).IsRequired().HasMaxLength(50);
        }
    }
}