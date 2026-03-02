using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class SitemapobjectRightConfiguration : IEntityTypeConfiguration<SitemapobjectRight>
{
    public void Configure(EntityTypeBuilder<SitemapobjectRight> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("sitemapobject_right");

        builder.HasIndex(e => e.Groupid, "groupid");

        builder.HasIndex(e => e.SitemapId, "sitemapId");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Access)
            .HasDefaultValueSql("'1'")
            .HasColumnType("int(11)")
            .HasColumnName("access");
        builder.Property(e => e.Groupid)
            .HasColumnType("int(11)")
            .HasColumnName("groupid");
        builder.Property(e => e.SitemapId)
            .HasColumnType("int(11)")
            .HasColumnName("sitemapId");
    }
}
