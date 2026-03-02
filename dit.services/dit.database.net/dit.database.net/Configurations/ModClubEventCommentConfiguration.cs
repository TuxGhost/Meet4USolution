using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubEventCommentConfiguration : IEntityTypeConfiguration<ModClubEventComment>
{
    public void Configure(EntityTypeBuilder<ModClubEventComment> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_event_comments");

        builder.HasIndex(e => e.UserId, "user_id");

        builder.HasIndex(e => e.EventDateId, "wallpost_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DateCreated)
            .HasColumnType("datetime")
            .HasColumnName("date_created");
        builder.Property(e => e.DateModified)
            .HasColumnType("datetime")
            .HasColumnName("date_modified");
        builder.Property(e => e.EventDateId)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("int(11) unsigned")
            .HasColumnName("event_date_id");
        builder.Property(e => e.FromApp).HasColumnName("from_app");
        builder.Property(e => e.Text)
            .HasColumnType("text")
            .HasColumnName("text");
        builder.Property(e => e.UserId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("user_id");
    }
}
