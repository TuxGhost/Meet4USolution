using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class WebsiteRightConfiguration : IEntityTypeConfiguration<WebsiteRight>
{
    public void Configure(EntityTypeBuilder<WebsiteRight> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("website_right");

        builder.HasIndex(e => e.Groupid, "groupid");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Access)
            .HasColumnType("int(1)")
            .HasColumnName("access");
        builder.Property(e => e.Groupid)
            .HasColumnType("int(11)")
            .HasColumnName("groupid");
        builder.Property(e => e.Website)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("website");
    }
}
