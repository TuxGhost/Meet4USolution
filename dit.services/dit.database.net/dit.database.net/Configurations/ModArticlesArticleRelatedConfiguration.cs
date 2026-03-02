using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModArticlesArticleRelatedConfiguration : IEntityTypeConfiguration<ModArticlesArticleRelated>
{
    public void Configure(EntityTypeBuilder<ModArticlesArticleRelated> builder)
    {
        builder.HasKey(e => new { e.ArticleId, e.ArticleRelatedId }).HasName("PRIMARY");

        builder.ToTable("mod_articles_article_related");

        builder.Property(e => e.ArticleId)
            .HasColumnType("int(11)")
            .HasColumnName("article_id");
        builder.Property(e => e.ArticleRelatedId)
            .HasColumnType("int(11)")
            .HasColumnName("article_related_id");
    }
}
