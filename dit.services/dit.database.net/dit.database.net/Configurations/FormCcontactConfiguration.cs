using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class FormCcontactConfiguration : IEntityTypeConfiguration<FormCcontact>
{
    public void Configure(EntityTypeBuilder<FormCcontact> builder)
    {
        builder.HasKey(e => e.CcontactId).HasName("PRIMARY");

        builder.ToTable("form_ccontact");

        builder.Property(e => e.CcontactId)
            .HasColumnType("int(11)")
            .HasColumnName("CContact_id");
        builder.Property(e => e.Address)
            .HasMaxLength(128)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("address");
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
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("name");
        builder.Property(e => e.Telephone)
            .HasMaxLength(25)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("telephone");
        builder.Property(e => e.Zipcode)
            .HasMaxLength(10)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("zipcode");
    }
}
