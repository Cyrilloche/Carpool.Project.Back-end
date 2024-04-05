using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Named the table of entity
            builder.ToTable("user");

            // Configure PrimaryKey
            builder.HasKey(u => u.Id);

            // Configure Property
            builder.Property(u => u.Id)
                .HasColumnType("int");
            builder.Property(u => u.Lastname)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(u => u.FirstName)
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();
            builder.Property(u => u.Email)
                .HasColumnType("varchar")
                .HasMaxLength(191) // Have to put 191 beacause index
                .IsRequired();
            builder.Property(u => u.Password)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(u => u.PhoneNumber)
                .HasColumnType("varchar")
                .HasMaxLength(25)
                .IsRequired();

            // Configure index on column
            builder.HasIndex(u => u.Email).IsUnique();

            // Configure one-to-many relationship between User and Status
            builder.HasOne<Status>(u => u.Status)
            .WithMany(s => s.Users)
            .HasForeignKey(u => u.Id);

            // Configure one-to-many relationship between User and DriverType
            builder.HasOne<DriverType>(u => u.DriverType)
            .WithMany(dt => dt.Users)
            .HasForeignKey(u => u.DriverTypeId);

            // Configure one-to-many relationship between User and Classroom
            builder.HasOne<Classroom>(u => u.Classroom)
            .WithMany(c => c.Users)
            .HasForeignKey(u => u.ClassroomId);
        }
    }
}