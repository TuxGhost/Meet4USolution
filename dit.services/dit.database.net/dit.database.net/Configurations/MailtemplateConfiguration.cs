using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class MailtemplateConfiguration : IEntityTypeConfiguration<Mailtemplate>
{
    public void Configure(EntityTypeBuilder<Mailtemplate> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mailtemplate");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Name)
            .HasMaxLength(128)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("name");
        builder.Property(e => e.Replacevars)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("text")
            .HasColumnName("replacevars");
    }
}
