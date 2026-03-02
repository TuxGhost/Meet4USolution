using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModCommunityAddressConfiguration : IEntityTypeConfiguration<ModCommunityAddress>
{
    public void Configure(EntityTypeBuilder<ModCommunityAddress> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_community_address");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.City)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("city");
        builder.Property(e => e.Companyname)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("companyname");
        builder.Property(e => e.Country)
            .HasMaxLength(100)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("country");
        builder.Property(e => e.Homepage)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("homepage");
        builder.Property(e => e.Street)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("street");
        builder.Property(e => e.Suburb)
            .HasMaxLength(32)
            .HasDefaultValueSql("''''''")
            .HasColumnName("suburb");
        builder.Property(e => e.Zipcode)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("zipcode");
        builder.Property(e => e.ZoneId)
            .HasMaxLength(5)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("zone_id");
    }
}
