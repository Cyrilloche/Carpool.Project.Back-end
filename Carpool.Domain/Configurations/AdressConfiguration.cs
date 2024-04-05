using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class AdressConfiguration : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.ToTable("adress");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id)
                .HasColumnType("int");
            builder.Property(a => a.AdressName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(a => a.City)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(a => a.PostalCode)
                .HasColumnType("tinyint")
                .IsRequired();

            builder.HasOne<School>(a => a.School)
                .WithMany(s => s.Adresses)
                .HasForeignKey(a => a.SchoolId);
        }
    }
}