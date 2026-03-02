using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModFormChoiceConfiguration : IEntityTypeConfiguration<ModFormChoice>
{
    public void Configure(EntityTypeBuilder<ModFormChoice> builder)
    {
        builder.HasKey(e => e.ChoiceId).HasName("PRIMARY");

        builder.ToTable("mod_form_choice");

        builder.HasIndex(e => e.FieldId, "field_id");

        builder.Property(e => e.ChoiceId)
            .HasColumnType("int(11)")
            .HasColumnName("choice_id");
        builder.Property(e => e.FieldId)
            .HasColumnType("int(5)")
            .HasColumnName("field_id");
        builder.Property(e => e.NameBe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name_be");
        builder.Property(e => e.NameDe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name_de");
        builder.Property(e => e.NameEn)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name_en");
        builder.Property(e => e.NameFr)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name_fr");
        builder.Property(e => e.NameNl)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name_nl");
        builder.Property(e => e.Selected)
            .HasColumnType("int(1)")
            .HasColumnName("selected");
        builder.Property(e => e.Sort)
            .HasColumnType("int(5)")
            .HasColumnName("sort");
        builder.Property(e => e.Value)
            .HasMaxLength(255)
            .HasColumnName("value");
    }
}
