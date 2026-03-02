using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubEventMembertypeConfiguration : IEntityTypeConfiguration<ModClubEventMembertype>
{
    public void Configure(EntityTypeBuilder<ModClubEventMembertype> builder)
    {
        builder.HasKey(e => new { e.EventId, e.Type }).HasName("PRIMARY");

        builder.ToTable("mod_club_event_membertype");

        builder.Property(e => e.EventId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("event_id");
        builder.Property(e => e.Type)
            .HasComment("0: Aspirant, 1: Lid, 2: Oud Lid")
            .HasColumnType("enum('0','1','2')")
            .HasColumnName("type");

        builder.HasOne(d => d.Event).WithMany(p => p.ModClubEventMembertypes)
            .HasForeignKey(d => d.EventId)
            .HasConstraintName("mod_club_event_membertype_ibfk_1");
    }
}
