using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ManualBarcodeConfiguration : IEntityTypeConfiguration<ManualBarcode>
{
    public void Configure(EntityTypeBuilder<ManualBarcode> builder)
    {
        builder.HasKey(e => e.Type).HasName("PRIMARY");

        builder.ToTable("manual_barcode");

        builder.Property(e => e.Type)
            .HasMaxLength(12)
            .HasColumnName("type");
        builder.Property(e => e.Number)
            .HasColumnType("bigint(20) unsigned")
            .HasColumnName("number");
    }
}
