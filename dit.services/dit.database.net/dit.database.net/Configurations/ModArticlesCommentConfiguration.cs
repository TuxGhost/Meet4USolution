using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModArticlesCommentConfiguration : IEntityTypeConfiguration<ModArticlesComment>
{
    public void Configure(EntityTypeBuilder<ModArticlesComment> builder)
    {
        builder.HasKey(e => e.CommentId).HasName("PRIMARY");

        builder.ToTable("mod_articles_comment");

        builder.HasIndex(e => e.ArticleId, "article_id");

        builder.HasIndex(e => e.ArticlesId, "articles_id");

        builder.HasIndex(e => e.UserId, "user_id");

        builder.Property(e => e.CommentId)
            .HasColumnType("int(11)")
            .HasColumnName("comment_id");
        builder.Property(e => e.ArticleId)
            .HasColumnType("int(11)")
            .HasColumnName("article_id");
        builder.Property(e => e.ArticlesId)
            .HasColumnType("int(11)")
            .HasColumnName("articles_id");
        builder.Property(e => e.Comment)
            .HasColumnType("text")
            .HasColumnName("comment");
        builder.Property(e => e.Date)
            .HasColumnType("datetime")
            .HasColumnName("date");
        builder.Property(e => e.Email)
            .HasMaxLength(255)
            .HasColumnName("email");
        builder.Property(e => e.Ip)
            .HasColumnType("int(11)")
            .HasColumnName("IP");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasColumnName("name");
        builder.Property(e => e.Url)
            .HasMaxLength(255)
            .HasColumnName("url");
        builder.Property(e => e.UserId)
            .HasColumnType("int(11)")
            .HasColumnName("user_id");
    }
}
