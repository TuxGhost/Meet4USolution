using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModForumForumConfiguration : IEntityTypeConfiguration<ModForumForum>
{
    public void Configure(EntityTypeBuilder<ModForumForum> builder)
    {
        builder.HasKey(e => e.ForumId).HasName("PRIMARY");

        builder.ToTable("mod_forum_forum");

        builder.Property(e => e.ForumId)
            .HasColumnType("int(11)")
            .HasColumnName("forum_id");
        builder.Property(e => e.CategoryId)
            .HasColumnType("int(11)")
            .HasColumnName("category_id");
        builder.Property(e => e.Description)
            .HasColumnType("text")
            .HasColumnName("description");
        builder.Property(e => e.Sort)
            .HasColumnType("int(5)")
            .HasColumnName("sort");
        builder.Property(e => e.Status)
            .HasDefaultValueSql("'1'")
            .HasColumnType("int(1)")
            .HasColumnName("status");
        builder.Property(e => e.Title)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title");
    }
}
