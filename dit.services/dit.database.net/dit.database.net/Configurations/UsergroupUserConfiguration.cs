using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class UsergroupUserConfiguration : IEntityTypeConfiguration<UsergroupUser>
{
    public void Configure(EntityTypeBuilder<UsergroupUser> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("usergroup_user");

        builder.HasIndex(e => new { e.Email, e.Groupid }, "email").IsUnique();

        builder.HasIndex(e => e.Email, "email_2");

        builder.HasIndex(e => e.Groupid, "groupid");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Admin)
            .HasColumnType("int(1)")
            .HasColumnName("admin");
        builder.Property(e => e.Email)
            .HasDefaultValueSql("''''''")
            .HasColumnName("email");
        builder.Property(e => e.Groupid)
            .HasColumnType("int(11)")
            .HasColumnName("groupid");
    }
}
