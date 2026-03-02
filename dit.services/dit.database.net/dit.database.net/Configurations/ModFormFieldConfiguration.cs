using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModFormFieldConfiguration : IEntityTypeConfiguration<ModFormField>
{
    public void Configure(EntityTypeBuilder<ModFormField> builder)
    {
        builder.HasKey(e => e.FieldId).HasName("PRIMARY");

        builder.ToTable("mod_form_field");

        builder.HasIndex(e => e.Active, "active");

        builder.HasIndex(e => e.FormId, "form_id");

        builder.HasIndex(e => e.Partof, "partof");

        builder.HasIndex(e => e.Type, "type");

        builder.Property(e => e.FieldId)
            .HasColumnType("int(11)")
            .HasColumnName("field_id");
        builder.Property(e => e.Action)
            .HasColumnType("text")
            .HasColumnName("action");
        builder.Property(e => e.Active)
            .HasColumnType("int(1)")
            .HasColumnName("active");
        builder.Property(e => e.CssId)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("css_id");
        builder.Property(e => e.FormId)
            .HasColumnType("int(11)")
            .HasColumnName("form_id");
        builder.Property(e => e.GrouplabelBe)
            .HasColumnType("text")
            .HasColumnName("grouplabel_be");
        builder.Property(e => e.GrouplabelDe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("grouplabel_de");
        builder.Property(e => e.GrouplabelEn)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("grouplabel_en");
        builder.Property(e => e.GrouplabelFr)
            .HasColumnType("text")
            .HasColumnName("grouplabel_fr");
        builder.Property(e => e.GrouplabelNl)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("grouplabel_nl");
        builder.Property(e => e.Height)
            .HasMaxLength(10)
            .HasDefaultValueSql("''''''")
            .HasColumnName("height");
        builder.Property(e => e.InAdminList)
            .HasColumnType("int(1)")
            .HasColumnName("in_admin_list");
        builder.Property(e => e.InMailAdmin)
            .HasColumnType("int(1)")
            .HasColumnName("in_mail_admin");
        builder.Property(e => e.InMailCustomer)
            .HasColumnType("int(1)")
            .HasColumnName("in_mail_customer");
        builder.Property(e => e.LabelBe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("label_be");
        builder.Property(e => e.LabelDe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("label_de");
        builder.Property(e => e.LabelEn)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("label_en");
        builder.Property(e => e.LabelFr)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("label_fr");
        builder.Property(e => e.LabelNl)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("label_nl");
        builder.Property(e => e.MaxInput)
            .HasColumnType("int(4)")
            .HasColumnName("max_input");
        builder.Property(e => e.Multiple)
            .HasColumnType("int(1)")
            .HasColumnName("multiple");
        builder.Property(e => e.Name)
            .HasMaxLength(64)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name");
        builder.Property(e => e.Obligated)
            .HasColumnType("int(1)")
            .HasColumnName("obligated");
        builder.Property(e => e.Partof)
            .HasColumnType("int(11)")
            .HasColumnName("partof");
        builder.Property(e => e.Password)
            .HasColumnType("int(1)")
            .HasColumnName("password");
        builder.Property(e => e.Related)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("related");
        builder.Property(e => e.Short)
            .HasColumnType("int(1)")
            .HasColumnName("short");
        builder.Property(e => e.Sort)
            .HasColumnType("int(5)")
            .HasColumnName("sort");
        builder.Property(e => e.StandardFieldcode)
            .HasMaxLength(5)
            .HasDefaultValueSql("''''''")
            .HasColumnName("standard_fieldcode");
        builder.Property(e => e.SubscriptionName)
            .HasMaxLength(128)
            .HasDefaultValueSql("''''''")
            .HasColumnName("subscription_name");
        builder.Property(e => e.Subtype)
            .HasMaxLength(32)
            .HasColumnName("subtype");
        builder.Property(e => e.Type)
            .HasMaxLength(32)
            .HasDefaultValueSql("''''''")
            .HasColumnName("type");
        builder.Property(e => e.ValidationType)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("validation_type");
        builder.Property(e => e.Width)
            .HasMaxLength(10)
            .HasDefaultValueSql("''''''")
            .HasColumnName("width");
    }
}
