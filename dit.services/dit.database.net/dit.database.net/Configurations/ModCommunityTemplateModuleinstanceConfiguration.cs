using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModCommunityTemplateModuleinstanceConfiguration : IEntityTypeConfiguration<ModCommunityTemplateModuleinstance>
{
    public void Configure(EntityTypeBuilder<ModCommunityTemplateModuleinstance> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_community_template_moduleinstance");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Moduleinstanceid)
            .HasColumnType("int(11)")
            .HasColumnName("moduleinstanceid");
        builder.Property(e => e.Orderme)
            .HasColumnType("int(11)")
            .HasColumnName("orderme");
        builder.Property(e => e.Ordernumber)
            .HasColumnType("int(11)")
            .HasColumnName("ordernumber");
        builder.Property(e => e.Template)
            .HasMaxLength(64)
            .HasDefaultValueSql("''''''")
            .HasColumnName("template");
        builder.Property(e => e.Websitename)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("websitename");
    }
}
