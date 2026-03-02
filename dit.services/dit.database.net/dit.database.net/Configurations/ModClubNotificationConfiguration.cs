using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubNotificationConfiguration : IEntityTypeConfiguration<ModClubNotification>
{
    public void Configure(EntityTypeBuilder<ModClubNotification> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_notifications");

        builder.HasIndex(e => e.Sent, "sent");

        builder.HasIndex(e => e.UserId, "user_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Data)
            .HasColumnType("text")
            .HasColumnName("data");
        builder.Property(e => e.DateCreated)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("date_created");
        builder.Property(e => e.Message)
            .HasColumnType("text")
            .HasColumnName("message");
        builder.Property(e => e.Opened).HasColumnName("opened");
        builder.Property(e => e.Sent).HasColumnName("sent");
        builder.Property(e => e.Title)
            .HasMaxLength(255)
            .HasColumnName("title");
        builder.Property(e => e.UserId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("user_id");
    }
}
