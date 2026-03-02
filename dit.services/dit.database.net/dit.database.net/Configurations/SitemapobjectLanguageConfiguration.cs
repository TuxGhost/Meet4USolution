using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class SitemapobjectLanguageConfiguration : IEntityTypeConfiguration<SitemapobjectLanguage>
{
    public void Configure(EntityTypeBuilder<SitemapobjectLanguage> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("sitemapobject_language");

        builder.HasIndex(e => e.Languageid, "languageid");

        builder.HasIndex(e => e.Sitemapid, "sitemapid");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Alias)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("alias");
        builder.Property(e => e.Description)
            .HasMaxLength(512)
            .HasColumnName("description");
        builder.Property(e => e.Image)
            .HasMaxLength(255)
            .HasColumnName("image");
        builder.Property(e => e.Languageid)
            .HasMaxLength(2)
            .HasDefaultValueSql("'''0'''")
            .IsFixedLength()
            .HasColumnName("languageid");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasColumnName("name");
        builder.Property(e => e.Sitemapid)
            .HasColumnType("int(11)")
            .HasColumnName("sitemapid");
        builder.Property(e => e.Visible)
            .HasDefaultValueSql("'1'")
            .HasColumnType("int(11)")
            .HasColumnName("visible");
    }
}
