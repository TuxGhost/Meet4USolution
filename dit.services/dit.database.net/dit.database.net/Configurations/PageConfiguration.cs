using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class PageConfiguration : IEntityTypeConfiguration<Page>
{
    public void Configure(EntityTypeBuilder<Page> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("page");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Css)
            .HasMaxLength(128)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("css");
        builder.Property(e => e.Date)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("date")
            .HasColumnName("date");
        builder.Property(e => e.Ignorewebsitetemplate)
            .HasDefaultValueSql("'0'")
            .HasColumnType("int(1)")
            .HasColumnName("ignorewebsitetemplate");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name");
        builder.Property(e => e.Template)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("template");
    }
}
