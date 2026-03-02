using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubUserAuthConfiguration : IEntityTypeConfiguration<ModClubUserAuth>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ModClubUserAuth> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_user_auth");

        builder.HasIndex(e => new { e.DeviceId, e.Website }, "device_id").IsUnique();

        builder.HasIndex(e => new { e.Email, e.Token }, "id").IsUnique();

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.DeviceId)
            .HasMaxLength(128)
            .HasColumnName("device_id");
        builder.Property(e => e.DeviceModel)
            .HasMaxLength(128)
            .HasColumnName("device_model");
        builder.Property(e => e.DevicePlatform)
            .HasMaxLength(64)
            .HasColumnName("device_platform");
        builder.Property(e => e.DeviceVersion)
            .HasMaxLength(16)
            .HasColumnName("device_version");
        builder.Property(e => e.Email).HasColumnName("email");
        builder.Property(e => e.PushId)
            .HasColumnType("text")
            .HasColumnName("push_id");
        builder.Property(e => e.Token)
            .HasMaxLength(128)
            .HasColumnName("token");
        builder.Property(e => e.Valid)
            .HasColumnType("datetime")
            .HasColumnName("valid");
        builder.Property(e => e.Version)
            .HasMaxLength(8)
            .HasDefaultValueSql("'''0.0.0'''")
            .HasColumnName("version");
        builder.Property(e => e.Website).HasColumnName("website");
    }
}
