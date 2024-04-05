using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.ToTable("classroom");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnType("int");
            builder.Property(c => c.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne<School>(c => c.School)
            .WithMany(s => s.Classrooms)
            .HasForeignKey(c => c.SchoolId);
        }
    }
}