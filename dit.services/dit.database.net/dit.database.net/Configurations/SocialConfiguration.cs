using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class SocialConfiguration : IEntityTypeConfiguration<Social>
{
    public void Configure(EntityTypeBuilder<Social> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("social");

        builder.HasIndex(e => e.ActiveWebsite, "active_website");

        builder.HasIndex(e => e.Name, "name");

        builder.HasIndex(e => e.UserId, "user_id");

        builder.Property(e => e.Id)
            .HasColumnType("tinyint(4)")
            .HasColumnName("id");
        builder.Property(e => e.AccessToken)
            .HasMaxLength(250)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("access_token");
        builder.Property(e => e.AccountId)
            .HasMaxLength(30)
            .HasColumnName("account_id");
        builder.Property(e => e.AccountName)
            .HasMaxLength(64)
            .HasColumnName("account_name");
        builder.Property(e => e.Active)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("active");
        builder.Property(e => e.ActiveWebsite).HasColumnName("active_website");
        builder.Property(e => e.Name)
            .HasMaxLength(30)
            .HasColumnName("name");
        builder.Property(e => e.Secret)
            .HasMaxLength(250)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("secret");
        builder.Property(e => e.Type)
            .HasMaxLength(20)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("type");
        builder.Property(e => e.UserId)
            .HasColumnType("int(11)")
            .HasColumnName("user_id");
    }
}
