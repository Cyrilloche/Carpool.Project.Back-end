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
            builder.ToTable("status");

            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id)
                .HasColumnType("int");
            builder.Property(s => s.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.HasData(
                new Status { Id = 1, Name = "Étudiant" },
                new Status { Id = 2, Name = "Intervenants" },
                new Status { Id = 3, Name = "Professeur" }
            );
        }
    }
}