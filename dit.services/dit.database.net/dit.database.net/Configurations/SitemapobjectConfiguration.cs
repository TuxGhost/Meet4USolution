using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class SitemapobjectConfiguration : IEntityTypeConfiguration<Sitemapobject>
{
    public void Configure(EntityTypeBuilder<Sitemapobject> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("sitemapobject");

        builder.HasIndex(e => e.Isfrontpage, "isfrontpage");

        builder.HasIndex(e => e.Ishomepage, "ishomepage");

        builder.HasIndex(e => e.Parent, "parent");

        builder.HasIndex(e => e.Websitename, "websitename");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Config)
            .HasColumnType("text")
            .HasColumnName("config");
        builder.Property(e => e.Isfrontpage)
            .HasColumnType("int(1)")
            .HasColumnName("isfrontpage");
        builder.Property(e => e.Ishomepage)
            .HasColumnType("int(1)")
            .HasColumnName("ishomepage");
        builder.Property(e => e.Link)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("link");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name");
        builder.Property(e => e.Orderme)
            .HasColumnType("int(11)")
            .HasColumnName("orderme");
        builder.Property(e => e.Parent)
            .HasColumnType("int(11)")
            .HasColumnName("parent");
        builder.Property(e => e.Target)
            .HasMaxLength(64)
            .HasDefaultValueSql("'''_self'''")
            .HasColumnName("target");
        builder.Property(e => e.Visible)
            .HasDefaultValueSql("'1'")
            .HasColumnType("int(1)")
            .HasColumnName("visible");
        builder.Property(e => e.Websitename)
            .HasDefaultValueSql("''''''")
            .HasColumnName("websitename");
    }
}
