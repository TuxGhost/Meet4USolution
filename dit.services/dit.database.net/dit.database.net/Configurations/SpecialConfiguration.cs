using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class SpecialConfiguration : IEntityTypeConfiguration<Special>
{
    public void Configure(EntityTypeBuilder<Special> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("specials");

        builder.HasIndex(e => e.Active, "active");

        builder.Property(e => e.Id)
            .HasColumnType("int(10) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.AliasEn)
            .HasMaxLength(64)
            .HasColumnName("alias_en");
        builder.Property(e => e.NameEn)
            .HasMaxLength(64)
            .HasColumnName("name_en");
    }
}
