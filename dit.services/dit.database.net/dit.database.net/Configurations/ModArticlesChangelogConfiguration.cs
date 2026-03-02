using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModArticlesChangelogConfiguration : IEntityTypeConfiguration<ModArticlesChangelog>
{
    public void Configure(EntityTypeBuilder<ModArticlesChangelog> builder)
    {
        builder.HasKey(e => e.ChangelogId).HasName("PRIMARY");

        builder.ToTable("mod_articles_changelog");

        builder.HasIndex(e => e.ArticleId, "article_id");

        builder.HasIndex(e => e.ArticlesId, "articles_id");

        builder.HasIndex(e => e.Author, "author");

        builder.HasIndex(e => e.Type, "type");

        builder.HasIndex(e => e.UserId, "user_id");

        builder.Property(e => e.ChangelogId)
            .HasColumnType("int(11)")
            .HasColumnName("changelog_id");
        builder.Property(e => e.ArticleId)
            .HasColumnType("int(11)")
            .HasColumnName("article_id");
        builder.Property(e => e.ArticlesId)
            .HasColumnType("int(11)")
            .HasColumnName("articles_id");
        builder.Property(e => e.Author).HasColumnName("author");
        builder.Property(e => e.Comments)
            .HasColumnType("text")
            .HasColumnName("comments");
        builder.Property(e => e.Date)
            .HasColumnType("datetime")
            .HasColumnName("date");
        builder.Property(e => e.Language)
            .HasMaxLength(2)
            .HasColumnName("language");
        builder.Property(e => e.Type)
            .HasMaxLength(15)
            .HasColumnName("type");
        builder.Property(e => e.UserId)
            .HasColumnType("int(11)")
            .HasColumnName("user_id");
    }
}
