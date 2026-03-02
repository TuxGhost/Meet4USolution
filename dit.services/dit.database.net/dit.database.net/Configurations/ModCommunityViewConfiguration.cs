using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModCommunityViewConfiguration : IEntityTypeConfiguration<ModCommunityView>
{
    public void Configure(EntityTypeBuilder<ModCommunityView> builder)
    {
        builder.HasKey(e => e.InstanceId).HasName("PRIMARY");

        builder.ToTable("mod_community_view");

        builder.Property(e => e.InstanceId)
            .HasColumnType("int(11)")
            .HasColumnName("instance_id");
        builder.Property(e => e.View)
            .HasMaxLength(1)
            .HasDefaultValueSql("''''''")
            .IsFixedLength()
            .HasColumnName("view");
    }
}
