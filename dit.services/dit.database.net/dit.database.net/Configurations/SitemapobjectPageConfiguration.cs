using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class SitemapobjectPageConfiguration : IEntityTypeConfiguration<SitemapobjectPage>
{
    public void Configure(EntityTypeBuilder<SitemapobjectPage> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("sitemapobject_page");

        builder.HasIndex(e => e.Pageid, "pageid");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Pageid)
            .HasColumnType("int(11)")
            .HasColumnName("pageid");
        builder.Property(e => e.Sitemapid)
            .HasColumnType("int(11)")
            .HasColumnName("sitemapid");
    }
}
