using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Status");

            builder.HasKey(s => s.StatusID);
            builder.Property(s => s.StatusName).IsRequired().HasMaxLength(50);

            builder.HasData(
                new Status { StatusID = 1, StatusName = "Étudiant" },
                new Status { StatusID = 2, StatusName = "Intervenants" },
                new Status { StatusID = 3, StatusName = "Professeur" }
            );
        }
    }
}