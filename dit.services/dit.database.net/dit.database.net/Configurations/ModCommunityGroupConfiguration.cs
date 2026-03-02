using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModCommunityGroupConfiguration : IEntityTypeConfiguration<ModCommunityGroup>
{
    public void Configure(EntityTypeBuilder<ModCommunityGroup> builder)
    {
        builder.HasKey(e => new { e.Id, e.ViewId }).HasName("PRIMARY");

        builder.ToTable("mod_community_group");

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.ViewId)
            .HasColumnType("int(11)")
            .HasColumnName("view_id");
        builder.Property(e => e.GroupId)
            .HasColumnType("int(11)")
            .HasColumnName("group_id");
    }
}
