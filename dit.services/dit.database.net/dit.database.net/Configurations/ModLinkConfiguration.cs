using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

internal class ModLinkConfiguration : IEntityTypeConfiguration<ModLink>
{
    public void Configure(EntityTypeBuilder<ModLink> builder)
    {
        builder.HasKey(e => e.LinksId).HasName("PRIMARY");

        builder.ToTable("mod_links");

        builder.Property(e => e.LinksId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("links_id");
        builder.Property(e => e.ListClass)
            .HasMaxLength(50)
            .HasColumnName("list_class");
        builder.Property(e => e.ListElement)
            .HasMaxLength(50)
            .HasColumnName("list_element");
        builder.Property(e => e.ShowTitle)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("show_title");
        builder.Property(e => e.SortOn)
            .HasMaxLength(100)
            .HasColumnName("sort_on");
        builder.Property(e => e.SortOrder)
            .HasMaxLength(5)
            .HasColumnName("sort_order");
        builder.Property(e => e.TitleBe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_be");
        builder.Property(e => e.TitleClass)
            .HasMaxLength(50)
            .HasColumnName("title_class");
        builder.Property(e => e.TitleDe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_de");
        builder.Property(e => e.TitleElement)
            .HasMaxLength(50)
            .HasColumnName("title_element");
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
    }
}
