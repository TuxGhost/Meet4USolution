using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistMailOptionConfiguration : IEntityTypeConfiguration<ModMailinglistMailOption>
{
    public void Configure(EntityTypeBuilder<ModMailinglistMailOption> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_mail_options");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.DefaultFontFamily)
            .HasMaxLength(255)
            .HasColumnName("default_font_family");
        builder.Property(e => e.DefaultSendfromName)
            .HasMaxLength(255)
            .HasColumnName("default_sendfrom_name");
        builder.Property(e => e.DefaultSendto)
            .HasDefaultValueSql("'-42'")
            .HasColumnType("int(11)")
            .HasColumnName("default_sendto");
        builder.Property(e => e.DefaultTemplate)
            .HasDefaultValueSql("'-42'")
            .HasColumnType("int(11)")
            .HasColumnName("default_template");
    }
}
