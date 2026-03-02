using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
{
    public void Configure(EntityTypeBuilder<Owner> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("owner");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Address)
            .HasMaxLength(128)
            .HasColumnName("address");
        builder.Property(e => e.BankAccount)
            .HasMaxLength(15)
            .HasColumnName("bank_account");
        builder.Property(e => e.BankBic)
            .HasMaxLength(255)
            .HasColumnName("bank_bic");
        builder.Property(e => e.BankDetails)
            .HasMaxLength(128)
            .HasColumnName("bank_details");
        builder.Property(e => e.BankIban)
            .HasMaxLength(32)
            .HasColumnName("bank_iban");
        builder.Property(e => e.BankName)
            .HasMaxLength(255)
            .HasColumnName("bank_name");
        builder.Property(e => e.City)
            .HasMaxLength(128)
            .HasColumnName("city");
        builder.Property(e => e.CocNumber)
            .HasMaxLength(64)
            .HasColumnName("coc_number");
        builder.Property(e => e.CountryId)
            .HasMaxLength(3)
            .HasColumnName("country_id");
        builder.Property(e => e.CreationDate)
            .HasColumnType("datetime")
            .HasColumnName("creation_date");
        builder.Property(e => e.Email)
            .HasMaxLength(255)
            .HasColumnName("email");
        builder.Property(e => e.Fax)
            .HasMaxLength(25)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("fax");
        builder.Property(e => e.FooterInvoice)
            .HasColumnType("text")
            .HasColumnName("footer_invoice");
        builder.Property(e => e.FooterOrder)
            .HasColumnType("text")
            .HasColumnName("footer_order");
        builder.Property(e => e.FooterShipping)
            .HasColumnType("text")
            .HasColumnName("footer_shipping");
        builder.Property(e => e.LastModified)
            .HasColumnType("datetime")
            .HasColumnName("last_modified");
        builder.Property(e => e.Latitude)
            .HasPrecision(15, 12)
            .HasColumnName("latitude");
        builder.Property(e => e.Logo)
            .HasMaxLength(255)
            .HasColumnName("logo");
        builder.Property(e => e.Logo2)
            .HasMaxLength(255)
            .HasColumnName("logo2");
        builder.Property(e => e.Longitude)
            .HasPrecision(15, 12)
            .HasColumnName("longitude");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasColumnName("name");
        builder.Property(e => e.Telephone)
            .HasMaxLength(25)
            .HasColumnName("telephone");
        builder.Property(e => e.VatNumber)
            .HasMaxLength(64)
            .HasColumnName("vat_number");
        builder.Property(e => e.Zipcode)
            .HasMaxLength(10)
            .HasColumnName("zipcode");
    }
}
