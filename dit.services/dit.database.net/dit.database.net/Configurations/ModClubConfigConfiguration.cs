using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubConfigConfiguration : IEntityTypeConfiguration<ModClubConfig>
{
    public void Configure(EntityTypeBuilder<ModClubConfig> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_config");

        builder.Property(e => e.Id)
            .HasColumnType("int(1) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.PdfFriends)
            .HasColumnType("text")
            .HasColumnName("pdf_friends");
        builder.Property(e => e.PdfPlus)
            .HasColumnType("text")
            .HasColumnName("pdf_plus");
        builder.Property(e => e.PriceRegfee)
            .HasPrecision(11)
            .HasColumnName("price_regfee");
        builder.Property(e => e.PriceSub)
            .HasPrecision(11)
            .HasColumnName("price_sub");
        builder.Property(e => e.PriceSubDigi)
            .HasPrecision(11)
            .HasColumnName("price_sub_digi");
    }
}
