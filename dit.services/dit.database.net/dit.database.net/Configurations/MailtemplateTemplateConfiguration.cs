using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class MailtemplateTemplateConfiguration : IEntityTypeConfiguration<MailtemplateTemplate>
{
    public void Configure(EntityTypeBuilder<MailtemplateTemplate> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mailtemplate_template");

        builder.HasIndex(e => e.TemplateId, "template_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Adminemail)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("adminemail");
        builder.Property(e => e.Adminname)
            .HasMaxLength(255)
            .HasColumnName("adminname");
        builder.Property(e => e.Alternativebody)
            .HasMaxLength(255)
            .HasColumnName("alternativebody");
        builder.Property(e => e.Attachment)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("attachment");
        builder.Property(e => e.Content)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("text")
            .HasColumnName("content");
        builder.Property(e => e.Css)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("text")
            .HasColumnName("css");
        builder.Property(e => e.Language)
            .HasMaxLength(2)
            .HasDefaultValueSql("'NULL'")
            .IsFixedLength()
            .HasColumnName("language");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("name");
        builder.Property(e => e.Replytoemail)
            .HasMaxLength(255)
            .HasColumnName("replytoemail");
        builder.Property(e => e.Replytoname)
            .HasMaxLength(255)
            .HasColumnName("replytoname");
        builder.Property(e => e.Senderemail)
            .HasMaxLength(255)
            .HasColumnName("senderemail");
        builder.Property(e => e.Sendername)
            .HasMaxLength(255)
            .HasColumnName("sendername");
        builder.Property(e => e.Subject)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("subject");
        builder.Property(e => e.TemplateId)
            .HasColumnType("int(11)")
            .HasColumnName("template_id");
    }
}
