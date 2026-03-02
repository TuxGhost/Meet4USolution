using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class SearchtableConfiguration : IEntityTypeConfiguration<Searchtable>
{
    public void Configure(EntityTypeBuilder<Searchtable> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("searchtable");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Fieldname)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("fieldname");
        builder.Property(e => e.Moduleid)
            .HasColumnType("int(11)")
            .HasColumnName("moduleid");
        builder.Property(e => e.Tablename)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("tablename");
    }
}
