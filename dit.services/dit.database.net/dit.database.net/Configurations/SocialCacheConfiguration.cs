using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class SocialCacheConfiguration : IEntityTypeConfiguration<SocialCache>
{
    public void Configure(EntityTypeBuilder<SocialCache> builder)
    {
        builder.HasKey(e => new { e.Network, e.UserId }).HasName("PRIMARY");

        builder.ToTable("social_cache");

        builder.Property(e => e.Network)
            .HasMaxLength(30)
            .HasColumnName("network");
        builder.Property(e => e.UserId)
            .HasColumnType("int(11)")
            .HasColumnName("user_id");
        builder.Property(e => e.Date)
            .HasColumnType("datetime")
            .HasColumnName("date");
        builder.Property(e => e.Message)
            .HasColumnType("text")
            .HasColumnName("message");
    }
}
