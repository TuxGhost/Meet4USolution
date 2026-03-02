using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class LanguageSiteConfiguration : IEntityTypeConfiguration<LanguageSite>
{
    public void Configure(EntityTypeBuilder<LanguageSite> builder)
    {
        builder.HasKey(e => new { e.Code, e.Website }).HasName("PRIMARY");

        builder.ToTable("language_site");

        builder.HasIndex(e => e.Website, "website");

        builder.Property(e => e.Code)
            .HasDefaultValueSql("''''''")
            .HasColumnName("code");
        builder.Property(e => e.Website)
            .HasDefaultValueSql("''''''")
            .HasColumnName("website");
        builder.Property(e => e.Defaultlan)
            .HasColumnType("int(1)")
            .HasColumnName("defaultlan");
    }
}
