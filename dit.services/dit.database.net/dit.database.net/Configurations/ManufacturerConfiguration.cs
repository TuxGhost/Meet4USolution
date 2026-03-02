using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
{
    public void Configure(EntityTypeBuilder<Manufacturer> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("manufacturer");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Address)
            .HasMaxLength(255)
            .HasColumnName("address");
        builder.Property(e => e.AliasEn)
            .HasMaxLength(255)
            .HasComment("array::string::#languages#::alias")
            .HasColumnName("alias_en");
        builder.Property(e => e.City)
            .HasMaxLength(128)
            .HasColumnName("city");
        builder.Property(e => e.CountryId)
            .HasMaxLength(2)
            .HasColumnName("country_id");
        builder.Property(e => e.CreationDate)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("creation_date");
        builder.Property(e => e.DescriptionEn)
            .HasDefaultValueSql("'NULL'")
            .HasComment("array::html::#languages#::description")
            .HasColumnType("text")
            .HasColumnName("description_en");
        builder.Property(e => e.Email)
            .HasMaxLength(255)
            .HasColumnName("email");
        builder.Property(e => e.Housenumber)
            .HasMaxLength(10)
            .HasColumnName("housenumber");
        builder.Property(e => e.Image)
            .HasColumnType("text")
            .HasColumnName("image");
        builder.Property(e => e.LastModified)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("last_modified");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasColumnName("name");
        builder.Property(e => e.Telephone)
            .HasMaxLength(25)
            .HasColumnName("telephone");
        builder.Property(e => e.Telephone2)
            .HasMaxLength(25)
            .HasColumnName("telephone2");
        builder.Property(e => e.Website)
            .HasMaxLength(255)
            .HasColumnName("website");
        builder.Property(e => e.Zipcode)
            .HasMaxLength(10)
            .HasColumnName("zipcode");
    }
}
