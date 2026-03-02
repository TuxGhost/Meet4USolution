using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModSimpleimageConfiguration : IEntityTypeConfiguration<ModSimpleimage>
{
    public void Configure(EntityTypeBuilder<ModSimpleimage> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_simpleimage");

        builder.HasIndex(e => e.Moduleid, "moduleid");

        builder.Property(e => e.Id)
            .HasColumnType("int(10) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Big).HasColumnName("big");
        builder.Property(e => e.BigHeight)
            .HasColumnType("int(4)")
            .HasColumnName("big_height");
        builder.Property(e => e.BigWidth)
            .HasColumnType("int(4)")
            .HasColumnName("big_width");
        builder.Property(e => e.Description)
            .HasMaxLength(255)
            .HasColumnName("description");
        builder.Property(e => e.DescriptionVisible).HasColumnName("description_visible");
        builder.Property(e => e.Icon).HasColumnName("icon");
        builder.Property(e => e.IconHeight)
            .HasColumnType("int(4)")
            .HasColumnName("icon_height");
        builder.Property(e => e.IconWidth)
            .HasColumnType("int(4)")
            .HasColumnName("icon_width");
        builder.Property(e => e.Moduleid)
            .HasColumnType("int(11)")
            .HasColumnName("moduleid");
        builder.Property(e => e.Original).HasColumnName("original");
        builder.Property(e => e.OriginalHeight)
            .HasColumnType("int(4)")
            .HasColumnName("original_height");
        builder.Property(e => e.OriginalWidth)
            .HasColumnType("int(4)")
            .HasColumnName("original_width");
        builder.Property(e => e.RandomSort).HasColumnName("random_sort");
        builder.Property(e => e.Resize).HasColumnName("resize");
        builder.Property(e => e.Thumb).HasColumnName("thumb");
        builder.Property(e => e.ThumbHeight)
            .HasColumnType("int(4)")
            .HasColumnName("thumb_height");
        builder.Property(e => e.ThumbWidth)
            .HasColumnType("int(4)")
            .HasColumnName("thumb_width");
        builder.Property(e => e.Transparency).HasColumnName("transparency");
        builder.Property(e => e.Variables)
            .HasColumnType("text")
            .HasColumnName("variables");
        builder.Property(e => e.View)
            .HasMaxLength(64)
            .HasDefaultValueSql("'''0'''")
            .HasColumnName("view");
        builder.Property(e => e.ViewType)
            .HasMaxLength(64)
            .HasDefaultValueSql("'''0'''")
            .HasColumnName("view_type");
    }
}
