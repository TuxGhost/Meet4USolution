using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistSavedConfiguration : IEntityTypeConfiguration<ModMailinglistSaved>
{
    public void Configure(EntityTypeBuilder<ModMailinglistSaved> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_saved");

        builder.HasIndex(e => e.AutoSave, "auto_save");

        builder.HasIndex(e => e.MailingType, "mailing_type");

        builder.HasIndex(e => e.MailinglistId, "mailinglist_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.AutoSave).HasColumnName("auto_save");
        builder.Property(e => e.Body)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("text")
            .HasColumnName("body");
        builder.Property(e => e.Edited)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("datetime")
            .HasColumnName("edited");
        builder.Property(e => e.FontFamily)
            .HasMaxLength(255)
            .HasColumnName("font_family");
        builder.Property(e => e.MailingType).HasColumnName("mailing_type");
        builder.Property(e => e.MailinglistId)
            .HasColumnType("int(11)")
            .HasColumnName("mailinglist_id");
        builder.Property(e => e.SendTo)
            .HasMaxLength(255)
            .HasColumnName("send_to");
        builder.Property(e => e.SenderEmail)
            .HasMaxLength(255)
            .HasColumnName("sender_email");
        builder.Property(e => e.SenderName)
            .HasMaxLength(255)
            .HasColumnName("sender_name");
        builder.Property(e => e.Subject)
            .HasMaxLength(255)
            .HasColumnName("subject");
        builder.Property(e => e.Testaddress)
            .HasMaxLength(255)
            .HasColumnName("testaddress");
        builder.Property(e => e.Title)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("text")
            .HasColumnName("title");
        builder.Property(e => e.Userid)
            .HasMaxLength(128)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("userid");
    }
}
