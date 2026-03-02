using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistBlockTypeConfiguration : IEntityTypeConfiguration<ModMailinglistBlockType>
{
    public void Configure(EntityTypeBuilder<ModMailinglistBlockType> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_block_types");

        builder.HasIndex(e => e.Type, "type");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Template)
            .HasColumnType("text")
            .HasColumnName("template");
        builder.Property(e => e.Type)
            .HasMaxLength(16)
            .HasColumnName("type");
    }
}
