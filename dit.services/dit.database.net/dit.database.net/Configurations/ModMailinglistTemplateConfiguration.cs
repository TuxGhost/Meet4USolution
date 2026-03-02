using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistTemplateConfiguration : IEntityTypeConfiguration<ModMailinglistTemplate>
{
    public void Configure(EntityTypeBuilder<ModMailinglistTemplate> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_template");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("active");
        builder.Property(e => e.Content)
            .HasColumnType("text")
            .HasColumnName("content");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasColumnName("name");
    }
}
