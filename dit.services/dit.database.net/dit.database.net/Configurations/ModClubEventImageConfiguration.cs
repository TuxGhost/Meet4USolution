using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubEventImageConfiguration : IEntityTypeConfiguration<ModClubEventImage>
{
    public void Configure(EntityTypeBuilder<ModClubEventImage> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_event_images");

        builder.HasIndex(e => e.EventId, "event_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.EventId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("event_id");
        builder.Property(e => e.Image)
            .HasColumnType("text")
            .HasColumnName("image");
        builder.Property(e => e.Sort)
            .HasColumnType("int(2)")
            .HasColumnName("sort");

        builder.HasOne(d => d.Event).WithMany(p => p.ModClubEventImages)
            .HasForeignKey(d => d.EventId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("mod_club_event_images_ibfk_1");
    }
}
