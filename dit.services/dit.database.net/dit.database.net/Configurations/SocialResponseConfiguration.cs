using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class SocialResponseConfiguration : IEntityTypeConfiguration<SocialResponse>
{
    public void Configure(EntityTypeBuilder<SocialResponse> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("social_response");

        builder.HasIndex(e => new { e.Module, e.Network }, "module");

        builder.Property(e => e.Id)
            .HasColumnType("bigint(20) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.InstanceId)
            .HasColumnType("bigint(20) unsigned")
            .HasColumnName("instance_id");
        builder.Property(e => e.Key)
            .HasMaxLength(255)
            .HasColumnName("key");
        builder.Property(e => e.Link)
            .HasMaxLength(255)
            .HasColumnName("link");
        builder.Property(e => e.Module)
            .HasMaxLength(48)
            .HasColumnName("module");
        builder.Property(e => e.Network)
            .HasMaxLength(30)
            .HasColumnName("network");
    }
}
