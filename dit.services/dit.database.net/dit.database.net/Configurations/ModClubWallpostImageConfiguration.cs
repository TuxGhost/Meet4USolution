using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubWallpostImageConfiguration : IEntityTypeConfiguration<ModClubWallpostImage>
{
    public void Configure(EntityTypeBuilder<ModClubWallpostImage> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_wallpost_images");

        builder.HasIndex(e => e.WallpostId, "wallpost_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Image)
            .HasColumnType("text")
            .HasColumnName("image");
        builder.Property(e => e.IsFile).HasColumnName("is_file");
        builder.Property(e => e.Sort)
            .HasColumnType("int(2)")
            .HasColumnName("sort");
        builder.Property(e => e.WallpostId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("wallpost_id");

        builder.HasOne(d => d.Wallpost).WithMany(p => p.ModClubWallpostImages)
            .HasForeignKey(d => d.WallpostId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("mod_club_wallpost_images_ibfk_1");
    }
}
