using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModLinksLinkConfiguration : IEntityTypeConfiguration<ModLinksLink>
{
    public void Configure(EntityTypeBuilder<ModLinksLink> builder)
    {
        builder.HasKey(e => e.LinkId).HasName("PRIMARY");

        builder.ToTable("mod_links_link");

        builder.HasIndex(e => e.LinksId, "links_id");

        builder.HasIndex(e => e.VisibleNl, "visible_nl");

        builder.Property(e => e.LinkId)
            .HasColumnType("int(11)")
            .HasColumnName("link_id");
        builder.Property(e => e.Active)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("active");
        builder.Property(e => e.Class)
            .HasMaxLength(50)
            .HasColumnName("class");
        builder.Property(e => e.CreationDate)
            .HasColumnType("datetime")
            .HasColumnName("creation_date");
        builder.Property(e => e.DescriptionBe)
            .HasColumnType("text")
            .HasColumnName("description_be");
        builder.Property(e => e.DescriptionDe)
            .HasColumnType("text")
            .HasColumnName("description_de");
        builder.Property(e => e.DescriptionEn)
            .HasColumnType("text")
            .HasColumnName("description_en");
        builder.Property(e => e.DescriptionFr)
            .HasColumnType("text")
            .HasColumnName("description_fr");
        builder.Property(e => e.DescriptionNl)
            .HasColumnType("text")
            .HasColumnName("description_nl");
        builder.Property(e => e.Image)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("text")
            .HasColumnName("image");
        builder.Property(e => e.LastModified)
            .HasColumnType("datetime")
            .HasColumnName("last_modified");
        builder.Property(e => e.LinkTarget)
            .HasMaxLength(16)
            .HasColumnName("link_target");
        builder.Property(e => e.LinksId)
            .HasColumnType("int(11)")
            .HasColumnName("links_id");
        builder.Property(e => e.Rel)
            .HasMaxLength(50)
            .HasColumnName("rel");
        builder.Property(e => e.SortOrder)
            .HasColumnType("int(5)")
            .HasColumnName("sort_order");
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
        builder.Property(e => e.VisibleBe)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("visible_be");
        builder.Property(e => e.VisibleDe)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("visible_de");
        builder.Property(e => e.VisibleEn)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("visible_en");
        builder.Property(e => e.VisibleFr)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("visible_fr");
        builder.Property(e => e.VisibleNl)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("visible_nl");
    }
}
