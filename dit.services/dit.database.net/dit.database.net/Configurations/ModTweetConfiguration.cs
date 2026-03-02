using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModTweetConfiguration : IEntityTypeConfiguration<ModTweet>
{
    public void Configure(EntityTypeBuilder<ModTweet> builder)
    {
        builder.HasKey(e => e.TweetsId).HasName("PRIMARY");

        builder.ToTable("mod_tweets");

        builder.Property(e => e.TweetsId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("tweets_id");
        builder.Property(e => e.Account)
            .HasMaxLength(255)
            .HasColumnName("account");
        builder.Property(e => e.Config)
            .HasColumnType("text")
            .HasColumnName("config");
        builder.Property(e => e.DescriptionNl)
            .HasColumnType("text")
            .HasColumnName("description_nl");
    }
}
