using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModBannerStatConfiguration : IEntityTypeConfiguration<ModBannerStat>
{
    public void Configure(EntityTypeBuilder<ModBannerStat> builder)
    {
        builder.HasKey(e => new { e.BannerId, e.BannerImageId, e.Date }).HasName("PRIMARY");

        builder.ToTable("mod_banner_stats");

        builder.Property(e => e.BannerId)
            .HasColumnType("int(11)")
            .HasColumnName("banner_id");
        builder.Property(e => e.BannerImageId)
            .HasColumnType("int(11)")
            .HasColumnName("banner_image_id");
        builder.Property(e => e.Date)
            .HasDefaultValueSql("'''0000-00-00'''")
            .HasColumnType("date")
            .HasColumnName("date");
        builder.Property(e => e.Clicks)
            .HasColumnType("int(11)")
            .HasColumnName("clicks");
        builder.Property(e => e.Views)
            .HasColumnType("int(11)")
            .HasColumnName("views");
    }
}
