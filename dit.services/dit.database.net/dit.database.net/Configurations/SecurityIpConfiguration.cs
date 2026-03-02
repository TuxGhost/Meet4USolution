using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class SecurityIpConfiguration : IEntityTypeConfiguration<SecurityIp>
{
    public void Configure(EntityTypeBuilder<SecurityIp> builder)
    {
        builder.HasKey(e => e.SecurityIpId).HasName("PRIMARY");

        builder.ToTable("security_ip");

        builder.HasIndex(e => new { e.SecurityId, e.Protected }, "security_id");

        builder.Property(e => e.SecurityIpId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("security_ip_id");
        builder.Property(e => e.Description)
            .HasMaxLength(255)
            .HasColumnName("description");
        builder.Property(e => e.Ip)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("ip");
        builder.Property(e => e.Protected).HasColumnName("protected");
        builder.Property(e => e.SecurityId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("security_id");
    }
}
