using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Domain.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("message");

            builder.HasKey(m => m.MessageID);
            builder.Property(m => m.MessageContent).IsRequired().HasMaxLength(1000);

            builder.HasOne<User>(m => m.UserSender)
            .WithMany(u => u.SentUserMessage)
            .HasForeignKey(m => m.SenderUserID);

            builder.HasOne<User>(m => m.UserReceiver)
            .WithMany(u => u.ReceivedUserMessage)
            .HasForeignKey(m => m.ReceiverUserID);
        }
    }
}