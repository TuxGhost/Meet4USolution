using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class FormTestFormConfiguration : IEntityTypeConfiguration<FormTestForm>
{
    public void Configure(EntityTypeBuilder<FormTestForm> builder)
    {
        builder.HasKey(e => e.TestFormId).HasName("PRIMARY");

        builder.ToTable("form_test_form");

        builder.Property(e => e.TestFormId)
            .HasColumnType("int(11)")
            .HasColumnName("test_form_id");
        builder.Property(e => e.Addition)
            .HasMaxLength(10)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("addition");
        builder.Property(e => e.City)
            .HasMaxLength(64)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("city");
        builder.Property(e => e.Comment)
            .HasColumnType("text")
            .HasColumnName("comment");
        builder.Property(e => e.Country)
            .HasMaxLength(3)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("country");
        builder.Property(e => e.Email)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("email");
        builder.Property(e => e.Firstname)
            .HasMaxLength(64)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("firstname");
        builder.Property(e => e.Housenumber)
            .HasMaxLength(10)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("housenumber");
        builder.Property(e => e.Infix)
            .HasMaxLength(10)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("infix");
        builder.Property(e => e.Lastname)
            .HasMaxLength(64)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("lastname");
        builder.Property(e => e.Pdf)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("pdf");
        builder.Property(e => e.Street)
            .HasMaxLength(128)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("street");
        builder.Property(e => e.Telephone)
            .HasMaxLength(25)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("telephone");
        builder.Property(e => e.Test)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("test");
        builder.Property(e => e.Title)
            .HasMaxLength(16)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("title");
        builder.Property(e => e.Zipcode)
            .HasMaxLength(10)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("zipcode");
    }
}
