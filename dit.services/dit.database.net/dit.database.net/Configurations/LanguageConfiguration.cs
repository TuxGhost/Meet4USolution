using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.HasKey(e => e.Code).HasName("PRIMARY");

        builder.ToTable("language");

        builder.Property(e => e.Code)
            .HasDefaultValueSql("''''''")
            .HasColumnName("code");
        builder.Property(e => e.Description)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("description");
        builder.Property(e => e.DescriptionEn)
            .HasMaxLength(255)
            .HasColumnName("description_en");
        builder.Property(e => e.DescriptionNl)
            .HasMaxLength(255)
            .HasColumnName("description_nl");
    }
}
