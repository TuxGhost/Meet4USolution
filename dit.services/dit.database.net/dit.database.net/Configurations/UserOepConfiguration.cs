using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class UserOepConfiguration : IEntityTypeConfiguration<UserOep>
{
    public void Configure(EntityTypeBuilder<UserOep> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("user_oeps");

        builder.HasIndex(e => e.Email, "email").IsUnique();

        builder.HasIndex(e => e.Status, "status");

        builder.HasIndex(e => new { e.System, e.Super }, "system");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Activate)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("activate");
        builder.Property(e => e.Avatar)
            .HasMaxLength(255)
            .HasColumnName("avatar");
        builder.Property(e => e.Email)
            .HasDefaultValueSql("''''''")
            .HasColumnName("email");
        builder.Property(e => e.JmlPassword)
            .HasMaxLength(100)
            .HasColumnName("jml_password");
        builder.Property(e => e.Js)
            .HasDefaultValueSql("'1'")
            .HasColumnType("int(1)")
            .HasColumnName("js");
        builder.Property(e => e.Language)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("language");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name");
        builder.Property(e => e.Password)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("password");
        builder.Property(e => e.PasswordResetKey)
            .HasMaxLength(32)
            .IsFixedLength()
            .HasColumnName("password_reset_key");
        builder.Property(e => e.PreferedWebsite)
            .HasMaxLength(255)
            .HasColumnName("prefered_website");
        builder.Property(e => e.Status).HasColumnName("status");
        builder.Property(e => e.Super).HasColumnName("super");
        builder.Property(e => e.System).HasColumnName("system");
        builder.Property(e => e.UserId)
            .HasMaxLength(32)
            .HasColumnName("user_id");
    }
}
