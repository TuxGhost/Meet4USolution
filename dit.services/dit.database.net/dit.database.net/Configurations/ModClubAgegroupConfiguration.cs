using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubAgegroupConfiguration : IEntityTypeConfiguration<ModClubAgegroup>
{
    public void Configure(EntityTypeBuilder<ModClubAgegroup> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_agegroup");

        builder.HasIndex(e => new { e.AgeFrom, e.AgeTo }, "age_from");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.AgeFrom)
            .HasComment("Leeftijd van")
            .HasColumnType("int(2)")
            .HasColumnName("age_from");
        builder.Property(e => e.AgeTo)
            .HasComment("Leeftijd t/m")
            .HasColumnType("int(2)")
            .HasColumnName("age_to");
        builder.Property(e => e.NameNl)
            .HasMaxLength(16)
            .HasComment("a, b, c, d, e, f, etc.")
            .HasColumnName("name_nl");
        builder.Property(e => e.ProfileId)
            .HasColumnType("int(11)")
            .HasColumnName("profile_id");
        builder.Property(e => e.Type)
            .HasComment("0: Friends, 1: Plus")
            .HasColumnName("type");
    }
}
