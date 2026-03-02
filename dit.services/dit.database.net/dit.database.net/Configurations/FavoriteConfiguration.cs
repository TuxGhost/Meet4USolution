using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class FavoriteConfiguration : IEntityTypeConfiguration<Favorite>
{
    public void Configure(EntityTypeBuilder<Favorite> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("favorites");

        builder.HasIndex(e => e.AccessType, "access_type");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.AccessCheck)
            .HasMaxLength(10)
            .HasColumnName("access_check");
        builder.Property(e => e.AccessType).HasColumnName("access_type");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DescriptionEn)
            .HasMaxLength(255)
            .HasColumnName("description_en");
        builder.Property(e => e.DescriptionNl)
            .HasMaxLength(255)
            .HasColumnName("description_nl");
        builder.Property(e => e.Icon)
            .HasMaxLength(255)
            .HasColumnName("icon");
        builder.Property(e => e.Link)
            .HasMaxLength(255)
            .HasColumnName("link");
        builder.Property(e => e.Order)
            .HasColumnType("tinyint(3) unsigned")
            .HasColumnName("order");
    }
}
