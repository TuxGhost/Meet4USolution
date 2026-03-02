using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModForumUserConfiguration : IEntityTypeConfiguration<ModForumUser>
{
    public void Configure(EntityTypeBuilder<ModForumUser> builder)
    {
        builder.HasKey(e => e.UserId).HasName("PRIMARY");

        builder.ToTable("mod_forum_user");

        builder.Property(e => e.UserId)
            .HasColumnType("int(11)")
            .HasColumnName("user_id");
        builder.Property(e => e.Avatar)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("avatar");
        builder.Property(e => e.Email)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("email");
        builder.Property(e => e.Signature)
            .HasColumnType("text")
            .HasColumnName("signature");
        builder.Property(e => e.UseAvatar)
            .HasColumnType("int(1)")
            .HasColumnName("use_avatar");
        builder.Property(e => e.UseSignature)
            .HasColumnType("int(1)")
            .HasColumnName("use_signature");
    }
}
