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
            builder.ToTable("User");

            // Configure PrimaryKey
            builder.HasKey(u => u.UserID);

            // Configure Property
            builder.Property(u => u.UserLastname).IsRequired().HasMaxLength(50);
            builder.Property(u => u.UserFirstName).IsRequired().HasMaxLength(30);
            builder.Property(u => u.UserEmail).IsRequired().HasMaxLength(255);
            builder.Property(u => u.UserPassword).IsRequired().HasMaxLength(255);
            builder.Property(u => u.UserPhoneNumber).IsRequired().HasMaxLength(25);

            // Configure one-to-many relationship between User and Status
            builder.HasOne<Status>(u => u.Status)
            .WithMany(s => s.Users)
            .HasForeignKey(u => u.UserID);
        }
    }
}