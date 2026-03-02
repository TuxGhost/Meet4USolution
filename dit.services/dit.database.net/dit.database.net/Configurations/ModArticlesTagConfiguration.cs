using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModArticlesTagConfiguration : IEntityTypeConfiguration<ModArticlesTag>
{
    public void Configure(EntityTypeBuilder<ModArticlesTag> builder)
    {
        builder.HasKey(e => e.TagId).HasName("PRIMARY");

        builder.ToTable("mod_articles_tag");

        builder.HasIndex(e => e.ArticlesId, "articles_id");

        builder.HasIndex(e => new { e.Language, e.Tag }, "language").IsUnique();

        builder.Property(e => e.TagId)
            .HasColumnType("int(11)")
            .HasColumnName("tag_id");
        builder.Property(e => e.ArticlesId)
            .HasColumnType("int(11)")
            .HasColumnName("articles_id");
        builder.Property(e => e.Language)
            .HasMaxLength(2)
            .HasColumnName("language");
        builder.Property(e => e.Tag).HasColumnName("tag");
    }
}
