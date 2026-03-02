using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModCommunityRegisterConfiguration : IEntityTypeConfiguration<ModCommunityRegister>
{
    public void Configure(EntityTypeBuilder<ModCommunityRegister> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_community_register");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Date)
            .HasDefaultValueSql("'''0000-00-00'''")
            .HasColumnType("date")
            .HasColumnName("date");
        builder.Property(e => e.Email)
            .HasMaxLength(70)
            .HasDefaultValueSql("''''''")
            .HasColumnName("email");
    }
}
