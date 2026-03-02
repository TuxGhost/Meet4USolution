using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubEventConfiguration : IEntityTypeConfiguration<ModClubEvent>
{
    public void Configure(EntityTypeBuilder<ModClubEvent> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_event");

        builder.HasIndex(e => e.Creator, "creator");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Address)
            .HasMaxLength(128)
            .HasColumnName("address");
        builder.Property(e => e.AliasNl)
            .HasMaxLength(255)
            .HasColumnName("alias_nl");
        builder.Property(e => e.AttendRepeat).HasColumnName("attend_repeat");
        builder.Property(e => e.AttendTill)
            .HasDefaultValueSql("'''0000-00-00'''")
            .HasColumnType("date")
            .HasColumnName("attend_till");
        builder.Property(e => e.BoardMemberEvent)
            .HasDefaultValueSql("'0'")
            .HasColumnName("board_member_event");
        builder.Property(e => e.ChildSafe).HasColumnName("child_safe");
        builder.Property(e => e.City)
            .HasMaxLength(128)
            .HasColumnName("city");
        builder.Property(e => e.Country)
            .HasMaxLength(2)
            .HasColumnName("country");
        builder.Property(e => e.Creator)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("int(11) unsigned")
            .HasColumnName("creator");
        builder.Property(e => e.DateCreated)
            .HasColumnType("datetime")
            .HasColumnName("date_created");
        builder.Property(e => e.DateModified)
            .HasColumnType("datetime")
            .HasColumnName("date_modified");
        builder.Property(e => e.DescriptionNl)
            .HasColumnType("text")
            .HasColumnName("description_nl");
        builder.Property(e => e.EventEnd)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("datetime")
            .HasColumnName("event_end");
        builder.Property(e => e.EventRepeat)
            .HasMaxLength(10)
            .HasColumnName("event_repeat");
        builder.Property(e => e.EventStart)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("datetime")
            .HasColumnName("event_start");
        builder.Property(e => e.EventTill)
            .HasDefaultValueSql("'''0000-00-00'''")
            .HasColumnType("date")
            .HasColumnName("event_till");
        builder.Property(e => e.Image)
            .HasColumnType("text")
            .HasColumnName("image");
        builder.Property(e => e.Lat)
            .HasPrecision(15, 12)
            .HasColumnName("lat");
        builder.Property(e => e.Lng)
            .HasPrecision(15, 12)
            .HasColumnName("lng");
        builder.Property(e => e.NameNl)
            .HasMaxLength(255)
            .HasColumnName("name_nl");
        builder.Property(e => e.OldId)
            .HasColumnType("int(11)")
            .HasColumnName("old_id");
        builder.Property(e => e.PaidEvent).HasColumnName("paid_event");
        builder.Property(e => e.PayAfter).HasColumnName("pay_after");
        builder.Property(e => e.Price)
            .HasPrecision(11)
            .HasColumnName("price");
        builder.Property(e => e.Priority).HasColumnName("priority");
        builder.Property(e => e.WheelchairSafe).HasColumnName("wheelchair_safe");
        builder.Property(e => e.Zipcode)
            .HasMaxLength(10)
            .HasColumnName("zipcode");

        builder.HasMany(d => d.Agegroups).WithMany(p => p.Events)
            .UsingEntity<Dictionary<string, object>>(
                "ModClubEventAgegroup",
                r => r.HasOne<ModClubAgegroup>().WithMany()
                    .HasForeignKey("AgegroupId")
                    .HasConstraintName("mod_club_event_agegroup_ibfk_2"),
                l => l.HasOne<ModClubEvent>().WithMany()
                    .HasForeignKey("EventId")
                    .HasConstraintName("mod_club_event_agegroup_ibfk_1"),
                j =>
                {
                    j.HasKey("EventId", "AgegroupId").HasName("PRIMARY");
                    j.ToTable("mod_club_event_agegroup");
                    j.HasIndex(new[] { "AgegroupId" }, "agegroup_id");
                    j.IndexerProperty<uint>("EventId")
                        .HasColumnType("int(11) unsigned")
                        .HasColumnName("event_id");
                    j.IndexerProperty<uint>("AgegroupId")
                        .HasColumnType("int(11) unsigned")
                        .HasColumnName("agegroup_id");
                });

        builder.HasMany(d => d.Tags).WithMany(p => p.Events)
            .UsingEntity<Dictionary<string, object>>(
                "ModClubEventTag",
                r => r.HasOne<ModClubTag>().WithMany()
                    .HasForeignKey("TagId")
                    .HasConstraintName("mod_club_event_tag_ibfk_2"),
                l => l.HasOne<ModClubEvent>().WithMany()
                    .HasForeignKey("EventId")
                    .HasConstraintName("mod_club_event_tag_ibfk_1"),
                j =>
                {
                    j.HasKey("EventId", "TagId").HasName("PRIMARY");
                    j.ToTable("mod_club_event_tag");
                    j.HasIndex(new[] { "TagId" }, "tag_id");
                    j.IndexerProperty<uint>("EventId")
                        .HasColumnType("int(11) unsigned")
                        .HasColumnName("event_id");
                    j.IndexerProperty<uint>("TagId")
                        .HasColumnType("int(11) unsigned")
                        .HasColumnName("tag_id");
                });
    }
}
