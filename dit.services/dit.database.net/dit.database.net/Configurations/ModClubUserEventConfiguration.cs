using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubUserEventConfiguration : IEntityTypeConfiguration<ModClubUserEvent>
{
    public void Configure(EntityTypeBuilder<ModClubUserEvent> builder)
    {
        builder.HasKey(e => new { e.UserId, e.EventDateId }).HasName("PRIMARY");

        builder.ToTable("mod_club_user_event");

        builder.HasIndex(e => e.EventDateId, "event_date_id");

        builder.Property(e => e.UserId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("user_id");
        builder.Property(e => e.EventDateId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("event_date_id");
        builder.Property(e => e.AttendDate)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("attend_date");
        builder.Property(e => e.UnsubscribePending).HasColumnName("unsubscribe_pending");

        builder.HasOne(d => d.EventDate).WithMany(p => p.ModClubUserEvents)
            .HasForeignKey(d => d.EventDateId)
            .HasConstraintName("mod_club_user_event_ibfk_2");
    }
}
