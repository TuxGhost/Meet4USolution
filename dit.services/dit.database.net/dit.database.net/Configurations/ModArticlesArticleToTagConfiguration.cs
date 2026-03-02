using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModArticlesArticleToTagConfiguration : IEntityTypeConfiguration<ModArticlesArticleToTag>
{
    public void Configure(EntityTypeBuilder<ModArticlesArticleToTag> builder)
    {
        builder.HasKey(e => new { e.ArticleId, e.TagId }).HasName("PRIMARY");

        builder.ToTable("mod_articles_article_to_tags");

        builder.Property(e => e.ArticleId)
            .HasColumnType("int(11)")
            .HasColumnName("article_id");
        builder.Property(e => e.TagId)
            .HasColumnType("int(11)")
            .HasColumnName("tag_id");
    }
}
