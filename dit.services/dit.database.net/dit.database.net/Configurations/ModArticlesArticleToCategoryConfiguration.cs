using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModArticlesArticleToCategoryConfiguration : IEntityTypeConfiguration<ModArticlesArticleToCategory>
{
    public void Configure(EntityTypeBuilder<ModArticlesArticleToCategory> builder)
    {
        builder.HasKey(e => new { e.ArticleId, e.CategoryId }).HasName("PRIMARY");

        builder.ToTable("mod_articles_article_to_categories");

        builder.HasIndex(e => e.CategoryId, "category_id");

        builder.Property(e => e.ArticleId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("article_id");
        builder.Property(e => e.CategoryId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("category_id");
    }
}
