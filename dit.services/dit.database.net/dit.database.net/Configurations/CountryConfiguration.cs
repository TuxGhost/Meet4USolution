using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("country");

        builder.HasIndex(e => e.Active, "active");

        builder.HasIndex(e => e.Continent, "continent");

        builder.HasIndex(e => e.Deprecated, "deprecated");

        builder.HasIndex(e => e.IsEu, "is_eu");

        builder.HasIndex(e => e.Territory, "territory");

        builder.Property(e => e.Id)
            .HasMaxLength(6)
            .HasColumnName("id");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Code)
            .HasMaxLength(6)
            .HasColumnName("code");
        builder.Property(e => e.Code3)
            .HasMaxLength(6)
            .HasColumnName("code3");
        builder.Property(e => e.Continent)
            .HasMaxLength(64)
            .HasColumnName("continent");
        builder.Property(e => e.Deprecated).HasColumnName("deprecated");
        builder.Property(e => e.IsEu).HasColumnName("is_eu");
        builder.Property(e => e.Iso)
            .HasMaxLength(64)
            .HasColumnName("iso");
        builder.Property(e => e.IsoReference)
            .HasMaxLength(128)
            .HasColumnName("iso_reference");
        builder.Property(e => e.IsoReferenceFr)
            .HasMaxLength(128)
            .HasColumnName("iso_reference_fr");
        builder.Property(e => e.NameDe)
            .HasMaxLength(128)
            .HasColumnName("name_de");
        builder.Property(e => e.NameEn)
            .HasMaxLength(128)
            .HasColumnName("name_en");
        builder.Property(e => e.NameFr)
            .HasMaxLength(128)
            .HasColumnName("name_fr");
        builder.Property(e => e.NameNl)
            .HasMaxLength(128)
            .HasColumnName("name_nl");
        builder.Property(e => e.Number)
            .HasMaxLength(6)
            .HasColumnName("number");
        builder.Property(e => e.SynDe)
            .HasMaxLength(255)
            .HasColumnName("syn_de");
        builder.Property(e => e.SynEn)
            .HasMaxLength(255)
            .HasColumnName("syn_en");
        builder.Property(e => e.SynFr)
            .HasMaxLength(255)
            .HasColumnName("syn_fr");
        builder.Property(e => e.SynNl)
            .HasMaxLength(255)
            .HasColumnName("syn_nl");
        builder.Property(e => e.Territory)
            .HasMaxLength(64)
            .HasColumnName("territory");
    }
}
