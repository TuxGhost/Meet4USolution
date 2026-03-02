using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistArchiveConfiguration : IEntityTypeConfiguration<ModMailinglistArchive>
{
    public void Configure(EntityTypeBuilder<ModMailinglistArchive> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_archive");

        builder.HasIndex(e => e.Email, "email");

        builder.HasIndex(e => e.MailingType, "mailing_type");

        builder.HasIndex(e => e.MailinglistId, "mailinglist_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Body)
            .HasColumnType("text")
            .HasColumnName("body");
        builder.Property(e => e.Document)
            .HasMaxLength(255)
            .HasColumnName("document");
        builder.Property(e => e.Email)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("email");
        builder.Property(e => e.MailingType)
            .HasColumnType("smallint(1)")
            .HasColumnName("mailing_type");
        builder.Property(e => e.MailinglistId)
            .HasColumnType("int(11)")
            .HasColumnName("mailinglist_id");
        builder.Property(e => e.Receivers)
            .HasColumnType("int(7)")
            .HasColumnName("receivers");
        builder.Property(e => e.SendTo)
            .HasColumnType("text")
            .HasColumnName("send_to");
        builder.Property(e => e.Sended)
            .HasColumnType("int(11)")
            .HasColumnName("sended");
        builder.Property(e => e.SenderEmail)
            .HasMaxLength(255)
            .HasColumnName("sender_email");
        builder.Property(e => e.SenderName)
            .HasMaxLength(255)
            .HasColumnName("sender_name");
        builder.Property(e => e.Sendtime)
            .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
            .HasColumnType("datetime")
            .HasColumnName("sendtime");
        builder.Property(e => e.Subject)
            .HasMaxLength(255)
            .HasColumnName("subject");
    }
}
