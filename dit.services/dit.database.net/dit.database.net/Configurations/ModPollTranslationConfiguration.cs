using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModPollTranslationConfiguration : IEntityTypeConfiguration<ModPollTranslation>
{
    public void Configure(EntityTypeBuilder<ModPollTranslation> builder)
    {
        builder.HasKey(e => e.TranslationId).HasName("PRIMARY");

        builder.ToTable("mod_poll_translation");

        builder.Property(e => e.TranslationId)
            .HasColumnType("int(11)")
            .HasColumnName("translation_id");
        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.LangCode)
            .HasMaxLength(25)
            .HasDefaultValueSql("''''''")
            .HasColumnName("lang_code");
        builder.Property(e => e.Translation)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("translation");
        builder.Property(e => e.Type)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("type");
    }
}
