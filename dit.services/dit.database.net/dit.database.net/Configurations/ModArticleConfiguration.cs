using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModArticleConfiguration : IEntityTypeConfiguration<ModArticle>
{
    public void Configure(EntityTypeBuilder<ModArticle> builder)
    {
        builder.HasKey(e => e.ArticlesId).HasName("PRIMARY");

        builder.ToTable("mod_articles");

        builder.Property(e => e.ArticlesId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("articles_id");
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
        builder.Property(e => e.CommentChars)
            .HasColumnType("int(5)")
            .HasColumnName("comment_chars");
        builder.Property(e => e.CreationDate)
            .HasColumnType("datetime")
            .HasColumnName("creation_date");
        builder.Property(e => e.DetailConfig)
            .HasColumnType("text")
            .HasColumnName("detail_config");
        builder.Property(e => e.DetailView)
            .HasMaxLength(50)
            .HasColumnName("detail_view");
        builder.Property(e => e.InstanceConfig)
            .HasColumnType("text")
            .HasColumnName("instance_config");
        builder.Property(e => e.LastModified)
            .HasColumnType("datetime")
            .HasColumnName("last_modified");
        builder.Property(e => e.Limiter)
            .HasColumnType("int(5)")
            .HasColumnName("limiter");
        builder.Property(e => e.ListConfig)
            .HasColumnType("text")
            .HasColumnName("list_config");
        builder.Property(e => e.RssEnabled)
            .HasColumnType("int(1)")
            .HasColumnName("rss_enabled");
        builder.Property(e => e.RssKey)
            .HasMaxLength(255)
            .HasColumnName("rss_key");
        builder.Property(e => e.RssLimiter)
            .HasColumnType("int(5)")
            .HasColumnName("rss_limiter");
        builder.Property(e => e.RssSortOn)
            .HasMaxLength(100)
            .HasColumnName("rss_sort_on");
        builder.Property(e => e.RssSortOrder)
            .HasMaxLength(5)
            .HasColumnName("rss_sort_order");
        builder.Property(e => e.ShowTitle)
            .HasColumnType("int(1)")
            .HasColumnName("show_title");
        builder.Property(e => e.SortOn)
            .HasMaxLength(100)
            .HasColumnName("sort_on");
        builder.Property(e => e.SortOrder)
            .HasMaxLength(5)
            .HasColumnName("sort_order");
        builder.Property(e => e.TargetPage)
            .HasColumnType("int(11)")
            .HasColumnName("target_page");
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
        builder.Property(e => e.UsesDataFrom)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("uses_data_from");
        builder.Property(e => e.View)
            .HasMaxLength(50)
            .HasColumnName("view");
    }
}
