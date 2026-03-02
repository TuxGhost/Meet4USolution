using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModBannerImageConfiguration : IEntityTypeConfiguration<ModBannerImage>
{
    public void Configure(EntityTypeBuilder<ModBannerImage> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_banner_image");

        builder.HasIndex(e => e.BannerId, "banner_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.BannerId)
            .HasColumnType("int(11)")
            .HasColumnName("banner_id");
        builder.Property(e => e.Company)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("company");
        builder.Property(e => e.Contact)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("contact");
        builder.Property(e => e.Email)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("email");
        builder.Property(e => e.EndDate)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("end_date");
        builder.Property(e => e.Photo)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("photo");
        builder.Property(e => e.PublishDate)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("publish_date");
        builder.Property(e => e.Sort)
            .HasColumnType("int(4)")
            .HasColumnName("sort");
        builder.Property(e => e.Telephone)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("telephone");
        builder.Property(e => e.Url)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("url");
        builder.Property(e => e.Vat)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("vat");
        builder.Property(e => e.Visible).HasColumnName("visible");
    }
}
