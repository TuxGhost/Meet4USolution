using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModCommunityModuleConfiguration : IEntityTypeConfiguration<ModCommunityModule>
{
    public void Configure(EntityTypeBuilder<ModCommunityModule> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_community_module");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Linktoinstanceid)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("int(11)")
            .HasColumnName("linktoinstanceid");
        builder.Property(e => e.Menuname)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("menuname");
        builder.Property(e => e.Moduleid)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("int(11)")
            .HasColumnName("moduleid");
        builder.Property(e => e.Website)
            .HasMaxLength(100)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("website");
    }
}
