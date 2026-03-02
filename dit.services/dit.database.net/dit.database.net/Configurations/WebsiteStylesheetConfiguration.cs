using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class WebsiteStylesheetConfiguration : IEntityTypeConfiguration<WebsiteStylesheet>
{
    public void Configure(EntityTypeBuilder<WebsiteStylesheet> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("website_stylesheet");

        builder.HasIndex(e => e.Name, "name");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Browser)
            .HasMaxLength(64)
            .HasDefaultValueSql("'''default'''")
            .HasColumnName("browser");
        builder.Property(e => e.Name).HasColumnName("name");
        builder.Property(e => e.Stylesheet)
            .HasMaxLength(64)
            .HasDefaultValueSql("'''style.css'''")
            .HasColumnName("stylesheet");
        builder.Property(e => e.VersionFrom)
            .HasPrecision(4, 1)
            .HasColumnName("version_from");
        builder.Property(e => e.VersionTo)
            .HasPrecision(4, 1)
            .HasColumnName("version_to");
    }
}
