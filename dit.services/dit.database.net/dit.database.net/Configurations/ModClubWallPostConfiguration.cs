using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubWallPostConfiguration : IEntityTypeConfiguration<ModClubWallpost>
{
    public void Configure(EntityTypeBuilder<ModClubWallpost> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_wallpost");

        builder.HasIndex(e => e.AgegroupId, "agegroup_id");

        builder.HasIndex(e => e.UserId, "user_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.AgegroupId)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("int(11) unsigned")
            .HasColumnName("agegroup_id");
        builder.Property(e => e.DateCreated)
            .HasColumnType("datetime")
            .HasColumnName("date_created");
        builder.Property(e => e.DateModified)
            .HasColumnType("datetime")
            .HasColumnName("date_modified");
        builder.Property(e => e.EventDateId)
            .HasColumnType("int(11)")
            .HasColumnName("event_date_id");
        builder.Property(e => e.ExtraId)
            .HasColumnType("int(11)")
            .HasColumnName("extra_id");
        builder.Property(e => e.Text)
            .HasColumnType("text")
            .HasColumnName("text");
        builder.Property(e => e.Type)
            .HasMaxLength(32)
            .HasColumnName("type");
        builder.Property(e => e.UserId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("user_id");

        builder.HasOne(d => d.Agegroup).WithMany(p => p.ModClubWallposts)
            .HasForeignKey(d => d.AgegroupId)
            .OnDelete(DeleteBehavior.SetNull)
            .HasConstraintName("mod_club_wallpost_ibfk_3");

        builder.HasMany(d => d.Agegroups).WithMany(p => p.Wallposts)
            .UsingEntity<Dictionary<string, object>>(
                "ModClubWallpostAgegroup",
                r => r.HasOne<ModClubAgegroup>().WithMany()
                    .HasForeignKey("AgegroupId")
                    .HasConstraintName("mod_club_wallpost_agegroup_ibfk_2"),
                l => l.HasOne<ModClubWallpost>().WithMany()
                    .HasForeignKey("WallpostId")
                    .HasConstraintName("mod_club_wallpost_agegroup_ibfk_1"),
                j =>
                {
                    j.HasKey("WallpostId", "AgegroupId").HasName("PRIMARY");
                    j.ToTable("mod_club_wallpost_agegroup");
                    j.HasIndex(new[] { "AgegroupId" }, "agegroup_id");
                    j.IndexerProperty<uint>("WallpostId")
                        .HasColumnType("int(11) unsigned")
                        .HasColumnName("wallpost_id");
                    j.IndexerProperty<uint>("AgegroupId")
                        .HasColumnType("int(11) unsigned")
                        .HasColumnName("agegroup_id");
                });
    }
}
