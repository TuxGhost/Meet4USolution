using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class IvaItemConfiguration : IEntityTypeConfiguration<IvaItem>
{
    public void Configure(EntityTypeBuilder<IvaItem> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("iva_items");

        builder.HasIndex(e => e.Active, "active");

        builder.HasIndex(e => e.Dc, "dc");

        builder.HasIndex(e => e.IvaId, "iva_id");

        builder.HasIndex(e => e.Sku, "sku");

        builder.HasIndex(e => e.TaxRateClassId, "tax_rate_class_id");

        builder.HasIndex(e => e.IvaType, "type");

        builder.Property(e => e.Id)
            .HasColumnType("bigint(20) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Account)
            .HasMaxLength(10)
            .HasColumnName("account");
        builder.Property(e => e.AccountRef)
            .HasColumnType("text")
            .HasColumnName("account_ref");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Auto).HasColumnName("auto");
        builder.Property(e => e.Dc)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("dc");
        builder.Property(e => e.Description)
            .HasColumnType("text")
            .HasColumnName("description");
        builder.Property(e => e.Excl)
            .HasColumnType("float(14,8)")
            .HasColumnName("excl");
        builder.Property(e => e.Incl)
            .HasColumnType("float(14,8)")
            .HasColumnName("incl");
        builder.Property(e => e.IvaId)
            .HasColumnType("bigint(20) unsigned")
            .HasColumnName("iva_id");
        builder.Property(e => e.IvaType)
            .HasColumnType("tinyint(2)")
            .HasColumnName("iva_type");
        builder.Property(e => e.ProductId)
            .HasColumnType("int(10) unsigned")
            .HasColumnName("product_id");
        builder.Property(e => e.Quantity)
            .HasColumnType("int(5)")
            .HasColumnName("quantity");
        builder.Property(e => e.Sku)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("sku");
        builder.Property(e => e.SumExcl)
            .HasColumnType("float(14,8)")
            .HasColumnName("sum_excl");
        builder.Property(e => e.SumIncl)
            .HasColumnType("float(14,8)")
            .HasColumnName("sum_incl");
        builder.Property(e => e.Tax)
            .HasColumnType("float(5,2)")
            .HasColumnName("tax");
        builder.Property(e => e.TaxAccount)
            .HasMaxLength(10)
            .HasColumnName("tax_account");
        builder.Property(e => e.TaxAccountRef)
            .HasColumnType("text")
            .HasColumnName("tax_account_ref");
        builder.Property(e => e.TaxAmount)
            .HasColumnType("float(14,8)")
            .HasColumnName("tax_amount");
        builder.Property(e => e.TaxFree).HasColumnName("tax_free");
        builder.Property(e => e.TaxRateClassId)
            .HasColumnType("smallint(6)")
            .HasColumnName("tax_rate_class_id");
    }
}
