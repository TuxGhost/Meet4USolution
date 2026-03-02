using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModCommunityMailtemplateConfiguration : IEntityTypeConfiguration<ModCommunityMailtemplate>
{
    public void Configure(EntityTypeBuilder<ModCommunityMailtemplate> builder)
    {
        builder.HasKey(e => e.TemplateId).HasName("PRIMARY");

        builder.ToTable("mod_community_mailtemplate");

        builder.Property(e => e.TemplateId)
            .HasColumnType("int(11)")
            .HasColumnName("template_id");
        builder.Property(e => e.Content)
            .HasColumnType("text")
            .HasColumnName("content");
        builder.Property(e => e.Css)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("css");
        builder.Property(e => e.Language)
            .HasMaxLength(100)
            .HasDefaultValueSql("''''''")
            .HasColumnName("language");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name");
        builder.Property(e => e.Subject)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("subject");
    }
}
