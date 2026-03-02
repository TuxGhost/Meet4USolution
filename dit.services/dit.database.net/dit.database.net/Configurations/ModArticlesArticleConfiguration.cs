using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModArticlesArticleConfiguration : IEntityTypeConfiguration<ModArticlesArticle>
{
    public void Configure(EntityTypeBuilder<ModArticlesArticle> builder)
    {
        builder.HasKey(e => e.ArticleId).HasName("PRIMARY");

        builder.ToTable("mod_articles_article");

        builder.HasIndex(e => e.ArticlesId, "articles_id");

        builder.HasIndex(e => new { e.InIndex, e.IsIndex }, "in_index");

        builder.HasIndex(e => e.VisibleNl, "visible_nl");

        builder.Property(e => e.ArticleId)
            .HasColumnType("int(11)")
            .HasColumnName("article_id");
        builder.Property(e => e.Active)
            .HasColumnType("int(1)")
            .HasColumnName("active");
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
            .HasDefaultValueSql("''''''")
            .HasColumnName("alias_nl");
        builder.Property(e => e.ArticlesId)
            .HasColumnType("int(11)")
            .HasColumnName("articles_id");
        builder.Property(e => e.Author)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
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
        builder.Property(e => e.Clicks)
            .HasColumnType("int(7)")
            .HasColumnName("clicks");
        builder.Property(e => e.Config)
            .HasColumnType("text")
            .HasColumnName("config");
        builder.Property(e => e.CreationDate)
            .HasColumnType("datetime")
            .HasColumnName("creation_date");
        builder.Property(e => e.EditDate)
            .HasColumnType("datetime")
            .HasColumnName("edit_date");
        builder.Property(e => e.EndDate)
            .HasColumnType("datetime")
            .HasColumnName("end_date");
        builder.Property(e => e.EventEnd)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("event_end");
        builder.Property(e => e.EventStart)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("event_start");
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
            .HasMaxLength(128)
            .HasDefaultValueSql("''''''")
            .HasColumnName("highlight_nl");
        builder.Property(e => e.Image)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("text")
            .HasColumnName("image");
        builder.Property(e => e.InIndex).HasColumnName("in_index");
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
        builder.Property(e => e.IsIndex).HasColumnName("is_index");
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
        builder.Property(e => e.LastModified)
            .HasColumnType("datetime")
            .HasColumnName("last_modified");
        builder.Property(e => e.LinkBe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("link_be");
        builder.Property(e => e.LinkDe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("link_de");
        builder.Property(e => e.LinkEn)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("link_en");
        builder.Property(e => e.LinkFr)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("link_fr");
        builder.Property(e => e.LinkNl)
            .HasColumnType("text")
            .HasColumnName("link_nl");
        builder.Property(e => e.PublishDate)
            .HasColumnType("datetime")
            .HasColumnName("publish_date");
        builder.Property(e => e.SortOrder)
            .HasColumnType("int(11)")
            .HasColumnName("sort_order");
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
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_nl");
        builder.Property(e => e.UserId)
            .HasColumnType("int(11)")
            .HasColumnName("user_id");
        builder.Property(e => e.VideoHeight)
            .HasColumnType("int(6)")
            .HasColumnName("video_height");
        builder.Property(e => e.VideoLink)
            .HasMaxLength(255)
            .HasColumnName("video_link");
        builder.Property(e => e.VideoWidth)
            .HasColumnType("int(6)")
            .HasColumnName("video_width");
        builder.Property(e => e.Views)
            .HasColumnType("int(7)")
            .HasColumnName("views");
        builder.Property(e => e.VisibleBe)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("visible_be");
        builder.Property(e => e.VisibleDe)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("visible_de");
        builder.Property(e => e.VisibleEn)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("visible_en");
        builder.Property(e => e.VisibleFr)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("visible_fr");
        builder.Property(e => e.VisibleNl)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("visible_nl");
    }
}
