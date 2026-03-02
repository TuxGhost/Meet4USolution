using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModSocialModuleinstanceConfiguration : IEntityTypeConfiguration<ModSocialModuleinstance>
{
    public void Configure(EntityTypeBuilder<ModSocialModuleinstance> builder)
    {
        builder.HasKey(e => e.ModuleinstanceId).HasName("PRIMARY");

        builder.ToTable("mod_social_moduleinstance");

        builder.Property(e => e.ModuleinstanceId)
            .HasColumnType("int(11)")
            .HasColumnName("moduleinstance_id");
        builder.Property(e => e.Config)
            .HasColumnType("text")
            .HasColumnName("config");
        builder.Property(e => e.View)
            .HasMaxLength(32)
            .HasDefaultValueSql("''''''")
            .HasColumnName("view");
    }
}
