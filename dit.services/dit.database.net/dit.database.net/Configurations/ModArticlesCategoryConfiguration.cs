using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModArticlesCategoryConfiguration : IEntityTypeConfiguration<ModArticlesCategory>
{
    public void Configure(EntityTypeBuilder<ModArticlesCategory> builder)
    {
        builder.HasKey(e => e.CategoryId).HasName("PRIMARY");

        builder.ToTable("mod_articles_category");

        builder.HasIndex(e => e.ArticlesId, "articles_id");

        builder.HasIndex(e => e.CategoryActive, "category_active");

        builder.HasIndex(e => e.CategoryParentId, "category_parent_id");

        builder.HasIndex(e => e.VisibleNl, "visible_nl");

        builder.Property(e => e.CategoryId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("category_id");
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
        builder.Property(e => e.CategoryActive).HasColumnName("category_active");
        builder.Property(e => e.CategoryParentId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("category_parent_id");
        builder.Property(e => e.CategoryReference)
            .HasMaxLength(32)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("category_reference");
        builder.Property(e => e.CategorySortOrder)
            .HasColumnType("int(3) unsigned")
            .HasColumnName("category_sort_order");
        builder.Property(e => e.CreationDate)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("datetime")
            .HasColumnName("creation_date");
        builder.Property(e => e.LastModified)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("datetime")
            .HasColumnName("last_modified");
        builder.Property(e => e.NameBe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name_be");
        builder.Property(e => e.NameDe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name_de");
        builder.Property(e => e.NameEn)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name_en");
        builder.Property(e => e.NameFr)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name_fr");
        builder.Property(e => e.NameNl)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("text")
            .HasColumnName("name_nl");
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
