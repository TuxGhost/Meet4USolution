using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class IvaConfiguration : IEntityTypeConfiguration<Iva>
{
    public void Configure(EntityTypeBuilder<Iva> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("iva");

        builder.HasIndex(e => e.CompanyId, "company_id");

        builder.HasIndex(e => e.Dc, "dc");

        builder.HasIndex(e => e.Debcred, "debcred");

        builder.HasIndex(e => e.Paid, "paid");

        builder.HasIndex(e => e.Period, "period");

        builder.HasIndex(e => e.Type, "type");

        builder.HasIndex(e => e.Year, "year");

        builder.Property(e => e.Id)
            .HasColumnType("bigint(20) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Account)
            .HasMaxLength(10)
            .HasColumnName("account");
        builder.Property(e => e.AccountRef)
            .HasColumnType("text")
            .HasColumnName("account_ref");
        builder.Property(e => e.Address)
            .HasMaxLength(128)
            .HasColumnName("address");
        builder.Property(e => e.BankAccount)
            .HasMaxLength(15)
            .HasColumnName("bank_account");
        builder.Property(e => e.City)
            .HasMaxLength(128)
            .HasColumnName("city");
        builder.Property(e => e.Comments)
            .HasColumnType("text")
            .HasColumnName("comments");
        builder.Property(e => e.CompanyId)
            .HasColumnType("int(11)")
            .HasColumnName("company_id");
        builder.Property(e => e.CompanyName)
            .HasMaxLength(255)
            .HasColumnName("company_name");
        builder.Property(e => e.CountryId)
            .HasMaxLength(2)
            .HasColumnName("country_id");
        builder.Property(e => e.Date)
            .HasColumnType("date")
            .HasColumnName("date");
        builder.Property(e => e.DatePaid)
            .HasColumnType("date")
            .HasColumnName("date_paid");
        builder.Property(e => e.Dc)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("dc");
        builder.Property(e => e.Debcred)
            .HasMaxLength(32)
            .HasColumnName("debcred");
        builder.Property(e => e.DebcredName)
            .HasMaxLength(255)
            .HasColumnName("debcred_name");
        builder.Property(e => e.Email)
            .HasMaxLength(255)
            .HasColumnName("email");
        builder.Property(e => e.Excl)
            .HasPrecision(14, 8)
            .HasColumnName("excl");
        builder.Property(e => e.Importexport).HasColumnName("importexport");
        builder.Property(e => e.Incl)
            .HasPrecision(14, 8)
            .HasColumnName("incl");
        builder.Property(e => e.Invoice)
            .HasMaxLength(255)
            .HasColumnName("invoice");
        builder.Property(e => e.InvoiceDate)
            .HasColumnType("date")
            .HasColumnName("invoice_date");
        builder.Property(e => e.InvoiceDocument)
            .HasMaxLength(255)
            .HasColumnName("invoice_document");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasColumnName("name");
        builder.Property(e => e.OrderId)
            .HasColumnType("bigint(20) unsigned")
            .HasColumnName("order_id");
        builder.Property(e => e.OwnReference)
            .HasMaxLength(128)
            .HasColumnName("own_reference");
        builder.Property(e => e.Paid).HasColumnName("paid");
        builder.Property(e => e.PayBeforeDate)
            .HasColumnType("date")
            .HasColumnName("pay_before_date");
        builder.Property(e => e.Period)
            .HasColumnType("smallint(5) unsigned")
            .HasColumnName("period");
        builder.Property(e => e.Reference)
            .HasMaxLength(128)
            .HasColumnName("reference");
        builder.Property(e => e.Telephone)
            .HasMaxLength(25)
            .HasColumnName("telephone");
        builder.Property(e => e.Type)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("type");
        builder.Property(e => e.VatNumber)
            .HasMaxLength(32)
            .HasColumnName("vat_number");
        builder.Property(e => e.Year)
            .HasColumnType("year(4)")
            .HasColumnName("year");
        builder.Property(e => e.Zipcode)
            .HasMaxLength(10)
            .HasColumnName("zipcode");
    }
}
