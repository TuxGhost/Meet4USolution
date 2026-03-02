using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistServerConfiguration : IEntityTypeConfiguration<ModMailinglistServer>
{
    public void Configure(EntityTypeBuilder<ModMailinglistServer> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_server");

        builder.HasIndex(e => e.MailinglistId, "mailinglist_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Emailaddress)
            .HasMaxLength(100)
            .HasColumnName("emailaddress");
        builder.Property(e => e.MailinglistId)
            .HasColumnType("int(11)")
            .HasColumnName("mailinglist_id");
        builder.Property(e => e.Name)
            .HasMaxLength(100)
            .HasColumnName("name");
        builder.Property(e => e.Password)
            .HasMaxLength(100)
            .HasColumnName("password");
        builder.Property(e => e.Subscribe)
            .HasMaxLength(100)
            .HasColumnName("subscribe");
        builder.Property(e => e.Unsubscribe)
            .HasMaxLength(100)
            .HasColumnName("unsubscribe");
        builder.Property(e => e.Username)
            .HasMaxLength(100)
            .HasColumnName("username");
    }
}
