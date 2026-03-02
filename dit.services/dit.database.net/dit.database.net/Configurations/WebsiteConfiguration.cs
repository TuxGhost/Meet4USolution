using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class WebsiteConfiguration : IEntityTypeConfiguration<Website>
{
    public void Configure(EntityTypeBuilder<Website> builder)
    {
        builder.HasKey(e => e.Name).HasName("PRIMARY");

        builder.ToTable("website");

        builder.HasIndex(e => e.Default, "default");

        builder.Property(e => e.Name).HasColumnName("name");
        builder.Property(e => e.BrowserDetection)
            .HasColumnType("tinyint(2) unsigned")
            .HasColumnName("browser_detection");
        builder.Property(e => e.BrowserSpecificStyle).HasColumnName("browser_specific_style");
        builder.Property(e => e.Creator)
            .HasMaxLength(255)
            .HasColumnName("creator");
        builder.Property(e => e.Css)
            .HasMaxLength(255)
            .HasColumnName("css");
        builder.Property(e => e.Default).HasColumnName("default");
        builder.Property(e => e.DefaultLanguage)
            .HasMaxLength(3)
            .HasColumnName("default_language");
        builder.Property(e => e.Description)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("text")
            .HasColumnName("description");
        builder.Property(e => e.DescriptionEn)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("text")
            .HasColumnName("description_en");
        builder.Property(e => e.Keywords)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("text")
            .HasColumnName("keywords");
        builder.Property(e => e.KeywordsEn)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("text")
            .HasColumnName("keywords_en");
        builder.Property(e => e.Sitemap)
            .HasMaxLength(255)
            .HasColumnName("sitemap");
        builder.Property(e => e.Status)
            .HasColumnType("tinyint(2) unsigned")
            .HasColumnName("status");
        builder.Property(e => e.Template)
            .HasMaxLength(255)
            .HasColumnName("template");
        builder.Property(e => e.Title)
            .HasMaxLength(255)
            .HasColumnName("title");
        builder.Property(e => e.TitleEn)
            .HasMaxLength(255)
            .HasColumnName("title_en");
        builder.Property(e => e.Url)
            .HasColumnType("text")
            .HasColumnName("url");
    }
}
