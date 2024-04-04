using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class TravelFilterConfiguration : IEntityTypeConfiguration<TravelFilter>
    {
        public void Configure(EntityTypeBuilder<TravelFilter> builder)
        {
            builder.ToTable("travel_filter");

            builder.HasKey(tf => new { tf.TravelId, tf.FilterId });

            builder.HasOne<Travel>(tf => tf.Travel)
            .WithMany(t => t.TravelFilters)
            .HasForeignKey(tf => tf.TravelId);

            builder.HasOne<Filter>(tf => tf.Filter)
            .WithMany(f => f.TravelFilters)
            .HasForeignKey(tf => tf.FilterId);
        }
    }
}