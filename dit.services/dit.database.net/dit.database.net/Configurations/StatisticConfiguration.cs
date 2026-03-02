using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class StatisticConfiguration : IEntityTypeConfiguration<Statistic>
{
    public void Configure(EntityTypeBuilder<Statistic> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("statistics");

        builder.HasIndex(e => e.Browser, "browser");

        builder.HasIndex(e => e.Country, "country");

        builder.HasIndex(e => e.Os, "os");

        builder.HasIndex(e => e.Siteid, "siteid");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Browser)
            .HasMaxLength(64)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("browser");
        builder.Property(e => e.Countnumber)
            .HasDefaultValueSql("'1'")
            .HasColumnType("int(255)")
            .HasColumnName("countnumber");
        builder.Property(e => e.Country)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("country");
        builder.Property(e => e.Date)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("date");
        builder.Property(e => e.DateLast)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("date_last");
        builder.Property(e => e.Ip)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("ip");
        builder.Property(e => e.Os)
            .HasMaxLength(64)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("os");
        builder.Property(e => e.Referer)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("referer");
        builder.Property(e => e.Siteid)
            .HasDefaultValueSql("''''''")
            .HasColumnName("siteid");
    }
}
