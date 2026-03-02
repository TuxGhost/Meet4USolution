using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubEventOrganisatorConfiguration : IEntityTypeConfiguration<ModClubEventOrganisator>
{
    public void Configure(EntityTypeBuilder<ModClubEventOrganisator> builder)
    {

        builder.HasKey(e => new { e.EventId, e.UserId }).HasName("PRIMARY");

        builder.ToTable("mod_club_event_organisator");

        builder.HasIndex(e => e.EventId, "event_id");

        builder.HasIndex(e => e.UserId, "mod_club_event_organisator_ibfk_1");

        builder.Property(e => e.EventId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("event_id");
        builder.Property(e => e.UserId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("user_id");

        builder.HasOne(d => d.Event).WithMany(p => p.ModClubEventOrganisators)
            .HasForeignKey(d => d.EventId)
            .HasConstraintName("mod_club_event_organisator_ibfk_2");
    }
}
