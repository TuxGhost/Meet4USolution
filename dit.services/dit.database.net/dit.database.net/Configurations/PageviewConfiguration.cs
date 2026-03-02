using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class PageviewConfiguration : IEntityTypeConfiguration<Pageview>
{
    public void Configure(EntityTypeBuilder<Pageview> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("pageviews");

        builder.HasIndex(e => e.Page, "page");

        builder.HasIndex(e => e.Siteid, "siteid");

        builder.Property(e => e.Id)
            .HasColumnType("int(255)")
            .HasColumnName("id");
        builder.Property(e => e.Date)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("date");
        builder.Property(e => e.Ip)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("ip");
        builder.Property(e => e.Page)
            .HasColumnType("int(255)")
            .HasColumnName("page");
        builder.Property(e => e.Siteid)
            .HasDefaultValueSql("''''''")
            .HasColumnName("siteid");
    }
}
