using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModSimpleimageImageConfiguration : IEntityTypeConfiguration<ModSimpleimageImage>
{
    public void Configure(EntityTypeBuilder<ModSimpleimageImage> builder)
    {
        builder.HasKey(e => e.ImageId).HasName("PRIMARY");

        builder.ToTable("mod_simpleimage_image");

        builder.HasIndex(e => e.ModuleId, "module_id");

        builder.Property(e => e.ImageId)
            .HasColumnType("int(11)")
            .HasColumnName("image_id");
        builder.Property(e => e.DescriptionBe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("description_be");
        builder.Property(e => e.DescriptionDe)
            .HasColumnType("text")
            .HasColumnName("description_de");
        builder.Property(e => e.DescriptionEn)
            .HasColumnType("text")
            .HasColumnName("description_en");
        builder.Property(e => e.DescriptionFr)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("description_fr");
        builder.Property(e => e.DescriptionNl)
            .HasColumnType("text")
            .HasColumnName("description_nl");
        builder.Property(e => e.ModuleId)
            .HasColumnType("int(11)")
            .HasColumnName("module_id");
        builder.Property(e => e.Photo)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("photo");
        builder.Property(e => e.Sort)
            .HasColumnType("int(4)")
            .HasColumnName("sort");
        builder.Property(e => e.TargetBe)
            .HasMaxLength(16)
            .HasDefaultValueSql("''''''")
            .HasColumnName("target_be");
        builder.Property(e => e.TargetDe)
            .HasMaxLength(16)
            .HasDefaultValueSql("''''''")
            .HasColumnName("target_de");
        builder.Property(e => e.TargetEn)
            .HasMaxLength(16)
            .HasDefaultValueSql("''''''")
            .HasColumnName("target_en");
        builder.Property(e => e.TargetFr)
            .HasMaxLength(16)
            .HasDefaultValueSql("''''''")
            .HasColumnName("target_fr");
        builder.Property(e => e.TargetNl)
            .HasMaxLength(16)
            .HasDefaultValueSql("''''''")
            .HasColumnName("target_nl");
        builder.Property(e => e.TitleBe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_be");
        builder.Property(e => e.TitleDe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_de");
        builder.Property(e => e.TitleEn)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_en");
        builder.Property(e => e.TitleFr)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_fr");
        builder.Property(e => e.TitleNl)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_nl");
        builder.Property(e => e.UrlBe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("url_be");
        builder.Property(e => e.UrlDe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("url_de");
        builder.Property(e => e.UrlEn)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("url_en");
        builder.Property(e => e.UrlFr)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("url_fr");
        builder.Property(e => e.UrlNl)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("url_nl");
        builder.Property(e => e.VisibleBe).HasColumnName("visible_be");
        builder.Property(e => e.VisibleDe).HasColumnName("visible_de");
        builder.Property(e => e.VisibleEn).HasColumnName("visible_en");
        builder.Property(e => e.VisibleFr).HasColumnName("visible_fr");
        builder.Property(e => e.VisibleNl).HasColumnName("visible_nl");
    }
}
