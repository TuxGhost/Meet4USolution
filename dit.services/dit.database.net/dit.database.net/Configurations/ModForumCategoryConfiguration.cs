using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModForumCategoryConfiguration : IEntityTypeConfiguration<ModForumCategory>
{
    public void Configure(EntityTypeBuilder<ModForumCategory> builder)
    {
        builder.HasKey(e => e.CategoryId).HasName("PRIMARY");

        builder.ToTable("mod_forum_category");

        builder.Property(e => e.CategoryId)
            .HasColumnType("int(11)")
            .HasColumnName("category_id");
        builder.Property(e => e.MainforumId)
            .HasColumnType("int(11)")
            .HasColumnName("mainforum_id");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name");
        builder.Property(e => e.Sort)
            .HasColumnType("int(5)")
            .HasColumnName("sort");
    }
}
