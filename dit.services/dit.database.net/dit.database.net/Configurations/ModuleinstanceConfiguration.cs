using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModuleinstanceConfiguration : IEntityTypeConfiguration<Moduleinstance>
{
    public void Configure(EntityTypeBuilder<Moduleinstance> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("moduleinstance");

        builder.HasIndex(e => e.Moduleid, "moduleid");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Config)
            .HasColumnType("text")
            .HasColumnName("config");
        builder.Property(e => e.Moduleid)
            .HasColumnType("int(11)")
            .HasColumnName("moduleid");
        builder.Property(e => e.Title)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title");
        builder.Property(e => e.View)
            .HasMaxLength(32)
            .HasColumnName("view");
    }
}
