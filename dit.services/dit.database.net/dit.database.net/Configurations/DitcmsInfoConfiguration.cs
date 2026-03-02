using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class DitcmsInfoConfiguration : IEntityTypeConfiguration<DitcmsInfo>
{
    public void Configure(EntityTypeBuilder<DitcmsInfo> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("ditcms_info");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Type)
            .HasMaxLength(250)
            .HasDefaultValueSql("''''''")
            .HasColumnName("type");
        builder.Property(e => e.Value)
            .HasMaxLength(250)
            .HasDefaultValueSql("''''''")
            .HasColumnName("value");
    }
}
