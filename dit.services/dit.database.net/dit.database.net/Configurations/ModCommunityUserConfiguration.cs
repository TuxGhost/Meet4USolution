using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModCommunityUserConfiguration : IEntityTypeConfiguration<ModCommunityUser>
{
    public void Configure(EntityTypeBuilder<ModCommunityUser> builder)
    {
        builder.HasKey(e => e.Email).HasName("PRIMARY");

        builder.ToTable("mod_community_user");

        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .HasDefaultValueSql("''''''")
            .HasColumnName("email");
        builder.Property(e => e.Address)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("int(11)")
            .HasColumnName("address");
        builder.Property(e => e.Dateofbirth)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("datetime")
            .HasColumnName("dateofbirth");
        builder.Property(e => e.Fax)
            .HasMaxLength(32)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("fax");
        builder.Property(e => e.FirstName)
            .HasMaxLength(100)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("first_name");
        builder.Property(e => e.Gender)
            .HasMaxLength(1)
            .HasDefaultValueSql("'NULL'")
            .IsFixedLength()
            .HasColumnName("gender");
        builder.Property(e => e.LastName)
            .HasMaxLength(100)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("last_name");
        builder.Property(e => e.Newsletter)
            .HasMaxLength(1)
            .HasDefaultValueSql("'NULL'")
            .IsFixedLength()
            .HasColumnName("newsletter");
        builder.Property(e => e.Signupformid)
            .HasDefaultValueSql("'0'")
            .HasColumnType("int(11)")
            .HasColumnName("signupformid");
        builder.Property(e => e.Signupid)
            .HasDefaultValueSql("'0'")
            .HasColumnType("int(11)")
            .HasColumnName("signupid");
        builder.Property(e => e.Telephone)
            .HasMaxLength(32)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("telephone");
    }
}
