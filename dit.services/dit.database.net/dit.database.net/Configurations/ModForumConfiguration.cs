using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModForumConfiguration : IEntityTypeConfiguration<ModForum>
{
    public void Configure(EntityTypeBuilder<ModForum> builder)
    {
        builder.HasKey(e => e.ForumId).HasName("PRIMARY");

        builder.ToTable("mod_forum");

        builder.Property(e => e.ForumId)
            .HasColumnType("int(11)")
            .HasColumnName("forum_id");
        builder.Property(e => e.AllowAvatars)
            .HasColumnType("int(1)")
            .HasColumnName("allow_avatars");
        builder.Property(e => e.AllowBbcode)
            .HasColumnType("int(1)")
            .HasColumnName("allow_bbcode");
        builder.Property(e => e.AllowHtml)
            .HasColumnType("int(1)")
            .HasColumnName("allow_html");
        builder.Property(e => e.AllowSignature)
            .HasColumnType("int(1)")
            .HasColumnName("allow_signature");
        builder.Property(e => e.AllowSmilies)
            .HasColumnType("int(1)")
            .HasColumnName("allow_smilies");
        builder.Property(e => e.Badwordinstance)
            .HasColumnType("int(5)")
            .HasColumnName("badwordinstance");
        builder.Property(e => e.Css)
            .HasColumnType("text")
            .HasColumnName("css");
        builder.Property(e => e.Ipblockinstance)
            .HasColumnType("int(5)")
            .HasColumnName("ipblockinstance");
        builder.Property(e => e.PostsPerPage)
            .HasColumnType("int(15)")
            .HasColumnName("posts_per_page");
        builder.Property(e => e.Registrationpage)
            .HasColumnType("int(5)")
            .HasColumnName("registrationpage");
        builder.Property(e => e.ShowTitle)
            .HasColumnType("int(1)")
            .HasColumnName("show_title");
        builder.Property(e => e.Title)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title");
        builder.Property(e => e.TopicsPerPage)
            .HasColumnType("int(15)")
            .HasColumnName("topics_per_page");
    }
}
