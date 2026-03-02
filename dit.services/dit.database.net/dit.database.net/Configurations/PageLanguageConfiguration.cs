using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class PageLanguageConfiguration : IEntityTypeConfiguration<PageLanguage>
{
    void IEntityTypeConfiguration<PageLanguage>.Configure(EntityTypeBuilder<PageLanguage> builder)
    {
        builder.HasKey(e => new { e.Id, e.Languageid }).HasName("PRIMARY");

        builder.ToTable("page_language");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Languageid)
            .HasMaxLength(2)
            .HasDefaultValueSql("'''0'''")
            .IsFixedLength()
            .HasColumnName("languageid");
        builder.Property(e => e.Description)
            .HasColumnType("text")
            .HasColumnName("description");
        builder.Property(e => e.Image)
            .HasMaxLength(255)
            .HasColumnName("image");
        builder.Property(e => e.Keywords)
            .HasColumnType("text")
            .HasColumnName("keywords");
        builder.Property(e => e.Title)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title");
    }
}
