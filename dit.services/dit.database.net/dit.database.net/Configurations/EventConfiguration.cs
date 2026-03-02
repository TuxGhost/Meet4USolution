using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("event");

        builder.HasIndex(e => e.Ad, "ad");

        builder.HasIndex(e => e.Cid, "cid");

        builder.HasIndex(e => e.Rem, "rem");

        builder.Property(e => e.Id)
            .HasColumnType("bigint(20)")
            .HasColumnName("id");
        builder.Property(e => e.Ad).HasColumnName("ad");
        builder.Property(e => e.Cid)
            .HasDefaultValueSql("'2'")
            .HasColumnType("smallint(6)")
            .HasColumnName("cid");
        builder.Property(e => e.End)
            .HasColumnType("datetime")
            .HasColumnName("end");
        builder.Property(e => e.Loc)
            .HasMaxLength(255)
            .HasColumnName("loc");
        builder.Property(e => e.Notes)
            .HasColumnType("text")
            .HasColumnName("notes");
        builder.Property(e => e.Rem)
            .HasMaxLength(16)
            .HasColumnName("rem");
        builder.Property(e => e.Start)
            .HasColumnType("datetime")
            .HasColumnName("start");
        builder.Property(e => e.Title)
            .HasMaxLength(255)
            .HasColumnName("title");
        builder.Property(e => e.Url)
            .HasMaxLength(255)
            .HasColumnName("url");
    }
}
