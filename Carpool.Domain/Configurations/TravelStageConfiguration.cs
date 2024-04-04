using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class TravelStageConfiguration : IEntityTypeConfiguration<TravelStage>
    {
        public void Configure(EntityTypeBuilder<TravelStage> builder)
        {
            builder.ToTable("travel_adress");

            builder.HasKey(ta => new { ta.TravelId, ta.AdressId });

            builder.HasOne<Travel>(ta => ta.Travel)
            .WithMany(t => t.TravelStages)
            .HasForeignKey(ta => ta.TravelId)
            .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne<Adress>(ta => ta.Adress)
            .WithMany(a => a.TravelStages)
            .HasForeignKey(ta => ta.AdressId)
            .OnDelete(DeleteBehavior.Cascade);

        }
    }
}