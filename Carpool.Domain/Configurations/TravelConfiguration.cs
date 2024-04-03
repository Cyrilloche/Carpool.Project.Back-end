using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class TravelConfiguration : IEntityTypeConfiguration<Travel>
    {
        public void Configure(EntityTypeBuilder<Travel> builder)
        {
            builder.ToTable("travel");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.TimeDeparture).IsRequired();
            builder.Property(t => t.DateDeparture).IsRequired();
            builder.Property(t => t.CreationDate).IsRequired();
            builder.Property(t => t.AvailablePlace).IsRequired();

            builder.HasOne<User>(t => t.Publisher)
            .WithMany(p => p.Travels)
            .HasForeignKey(t => t.PublisherId);
        }
    }
}