using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModForumPostConfiguration : IEntityTypeConfiguration<ModForumPost>
{
    public void Configure(EntityTypeBuilder<ModForumPost> builder)
    {
        builder.HasKey(e => e.PostId).HasName("PRIMARY");

        builder.ToTable("mod_forum_post");

        builder.Property(e => e.PostId)
            .HasColumnType("int(11)")
            .HasColumnName("post_id");
        builder.Property(e => e.EditedBy)
            .HasColumnType("int(5)")
            .HasColumnName("edited_by");
        builder.Property(e => e.ForumId)
            .HasColumnType("int(11)")
            .HasColumnName("forum_id");
        builder.Property(e => e.Ip)
            .HasMaxLength(15)
            .HasDefaultValueSql("''''''")
            .HasColumnName("ip");
        builder.Property(e => e.LastEdit)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("last_edit");
        builder.Property(e => e.LastView)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("last_view");
        builder.Property(e => e.Post)
            .HasColumnType("text")
            .HasColumnName("post");
        builder.Property(e => e.Postdate)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("postdate");
        builder.Property(e => e.PosterId)
            .HasColumnType("int(5)")
            .HasColumnName("poster_id");
        builder.Property(e => e.ReplyOn)
            .HasDefaultValueSql("'-1'")
            .HasColumnType("int(11)")
            .HasColumnName("reply_on");
        builder.Property(e => e.Status)
            .HasDefaultValueSql("'1'")
            .HasColumnType("int(1)")
            .HasColumnName("status");
        builder.Property(e => e.Subject)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("subject");
        builder.Property(e => e.TimesViewed)
            .HasColumnType("int(11)")
            .HasColumnName("times_viewed");
    }
}
