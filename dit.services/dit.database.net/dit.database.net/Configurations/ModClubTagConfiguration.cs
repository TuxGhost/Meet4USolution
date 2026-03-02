using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubTagConfiguration : IEntityTypeConfiguration<ModClubTag>
{
    public void Configure(EntityTypeBuilder<ModClubTag> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_tag");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.NameNl)
            .HasMaxLength(64)
            .HasColumnName("name_nl");
        builder.Property(e => e.System)
            .HasComment("System tags, can't be removed.")
            .HasColumnName("system");
    }
}
