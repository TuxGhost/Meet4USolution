using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

internal class ModArticlesArticleRevisionConfiguration : IEntityTypeConfiguration<ModArticlesArticleRevision>
{
    public void Configure(EntityTypeBuilder<ModArticlesArticleRevision> builder)
    {
        builder.HasKey(e => e.RevisionId).HasName("PRIMARY");

        builder.ToTable("mod_articles_article_revision");

        builder.HasIndex(e => new { e.ArticleId, e.UserId }, "article_id");

        builder.Property(e => e.RevisionId)
            .HasColumnType("int(11)")
            .HasColumnName("revision_id");
        builder.Property(e => e.AliasBe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("alias_be");
        builder.Property(e => e.AliasDe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("alias_de");
        builder.Property(e => e.AliasEn)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("alias_en");
        builder.Property(e => e.AliasFr)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("alias_fr");
        builder.Property(e => e.AliasNl)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("alias_nl");
        builder.Property(e => e.ArticleId)
            .HasColumnType("int(11)")
            .HasColumnName("article_id");
        builder.Property(e => e.Author)
            .HasMaxLength(255)
            .HasColumnName("author");
        builder.Property(e => e.BodyBe)
            .HasColumnType("text")
            .HasColumnName("body_be");
        builder.Property(e => e.BodyDe)
            .HasColumnType("text")
            .HasColumnName("body_de");
        builder.Property(e => e.BodyEn)
            .HasColumnType("text")
            .HasColumnName("body_en");
        builder.Property(e => e.BodyFr)
            .HasColumnType("text")
            .HasColumnName("body_fr");
        builder.Property(e => e.BodyNl)
            .HasColumnType("text")
            .HasColumnName("body_nl");
        builder.Property(e => e.Comments)
            .HasColumnType("text")
            .HasColumnName("comments");
        builder.Property(e => e.CreationDate)
            .HasColumnType("datetime")
            .HasColumnName("creation_date");
        builder.Property(e => e.HighlightBe)
            .HasMaxLength(16)
            .HasDefaultValueSql("''''''")
            .HasColumnName("highlight_be");
        builder.Property(e => e.HighlightDe)
            .HasMaxLength(16)
            .HasDefaultValueSql("''''''")
            .HasColumnName("highlight_de");
        builder.Property(e => e.HighlightEn)
            .HasMaxLength(16)
            .HasDefaultValueSql("''''''")
            .HasColumnName("highlight_en");
        builder.Property(e => e.HighlightFr)
            .HasMaxLength(16)
            .HasDefaultValueSql("''''''")
            .HasColumnName("highlight_fr");
        builder.Property(e => e.HighlightNl)
            .HasMaxLength(16)
            .HasColumnName("highlight_nl");
        builder.Property(e => e.IntroBe)
            .HasColumnType("text")
            .HasColumnName("intro_be");
        builder.Property(e => e.IntroDe)
            .HasColumnType("text")
            .HasColumnName("intro_de");
        builder.Property(e => e.IntroEn)
            .HasColumnType("text")
            .HasColumnName("intro_en");
        builder.Property(e => e.IntroFr)
            .HasColumnType("text")
            .HasColumnName("intro_fr");
        builder.Property(e => e.IntroNl)
            .HasColumnType("text")
            .HasColumnName("intro_nl");
        builder.Property(e => e.KeywordsBe)
            .HasColumnType("text")
            .HasColumnName("keywords_be");
        builder.Property(e => e.KeywordsDe)
            .HasColumnType("text")
            .HasColumnName("keywords_de");
        builder.Property(e => e.KeywordsEn)
            .HasColumnType("text")
            .HasColumnName("keywords_en");
        builder.Property(e => e.KeywordsFr)
            .HasColumnType("text")
            .HasColumnName("keywords_fr");
        builder.Property(e => e.KeywordsNl)
            .HasColumnType("text")
            .HasColumnName("keywords_nl");
        builder.Property(e => e.Revision)
            .HasColumnType("int(11)")
            .HasColumnName("revision");
        builder.Property(e => e.TitleBe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_be");
        builder.Property(e => e.TitleDe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_de");
        builder.Property(e => e.TitleEn)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_en");
        builder.Property(e => e.TitleFr)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_fr");
        builder.Property(e => e.TitleNl)
            .HasMaxLength(255)
            .HasColumnName("title_nl");
        builder.Property(e => e.UserId)
            .HasColumnType("int(11)")
            .HasColumnName("user_id");
        builder.Property(e => e.Version)
            .HasMaxLength(64)
            .HasColumnName("version");
    }
}
