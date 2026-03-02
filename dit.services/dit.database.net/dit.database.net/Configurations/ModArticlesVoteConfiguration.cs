using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModArticlesVoteConfiguration : IEntityTypeConfiguration<ModArticlesVote>
{
    public void Configure(EntityTypeBuilder<ModArticlesVote> builder)
    {
        builder.HasKey(e => e.VoteId).HasName("PRIMARY");

        builder.ToTable("mod_articles_vote");

        builder.Property(e => e.VoteId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("vote_id");
        builder.Property(e => e.ArticleId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("article_id");
        builder.Property(e => e.Date)
            .HasColumnType("datetime")
            .HasColumnName("date");
        builder.Property(e => e.Ip)
            .HasColumnType("int(11)")
            .HasColumnName("IP");
        builder.Property(e => e.Vote)
            .HasColumnType("int(2)")
            .HasColumnName("vote");
    }
}
