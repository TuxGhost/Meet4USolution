using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubEventDateConfiguration : IEntityTypeConfiguration<ModClubEventDate>
{
    public void Configure(EntityTypeBuilder<ModClubEventDate> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_event_date");

        builder.HasIndex(e => e.EventId, "event_id");

        builder.HasIndex(e => new { e.Start, e.End }, "start");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.AttendTill)
            .HasDefaultValueSql("'''0000-00-00'''")
            .HasColumnType("date")
            .HasColumnName("attend_till");
        builder.Property(e => e.CancelledOn)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("datetime")
            .HasColumnName("cancelled_on");
        builder.Property(e => e.End)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("end");
        builder.Property(e => e.EventId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("event_id");
        builder.Property(e => e.Start)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("start");

        builder.HasOne(d => d.Event).WithMany(p => p.ModClubEventDates)
            .HasForeignKey(d => d.EventId)
            .HasConstraintName("mod_club_event_date_ibfk_1");
    }
}
