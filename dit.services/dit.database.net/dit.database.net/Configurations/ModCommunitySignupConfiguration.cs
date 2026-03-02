using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModCommunitySignupConfiguration : IEntityTypeConfiguration<ModCommunitySignup>
{
    public void Configure(EntityTypeBuilder<ModCommunitySignup> builder)
    {
        builder.HasKey(e => e.SignupId).HasName("PRIMARY");

        builder.ToTable("mod_community_signup");

        builder.Property(e => e.SignupId)
            .HasColumnType("int(11)")
            .HasColumnName("signup_id");
        builder.Property(e => e.Adminmail)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("adminmail");
        builder.Property(e => e.Signupform)
            .HasDefaultValueSql("'0'")
            .HasColumnType("int(11)")
            .HasColumnName("signupform");
        builder.Property(e => e.Template)
            .HasColumnType("int(5)")
            .HasColumnName("template");
        builder.Property(e => e.TypeActivation)
            .HasMaxLength(20)
            .HasDefaultValueSql("''''''")
            .HasColumnName("type_activation");
        builder.Property(e => e.Usergroups)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("usergroups");
    }
}
