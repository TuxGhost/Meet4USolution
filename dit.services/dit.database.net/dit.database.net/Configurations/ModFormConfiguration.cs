using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModFormConfiguration : IEntityTypeConfiguration<ModForm>
{
    public void Configure(EntityTypeBuilder<ModForm> builder)
    {
        builder.HasKey(e => e.FormId).HasName("PRIMARY");

        builder.ToTable("mod_form");

        builder.Property(e => e.FormId)
            .HasColumnType("int(11)")
            .HasColumnName("form_id");
        builder.Property(e => e.ConfirmationmailAdmin)
            .HasColumnType("int(5)")
            .HasColumnName("confirmationmail_admin");
        builder.Property(e => e.ConfirmationmailCustomer)
            .HasColumnType("int(5)")
            .HasColumnName("confirmationmail_customer");
        builder.Property(e => e.ConfirmtextBe)
            .HasColumnType("text")
            .HasColumnName("confirmtext_be");
        builder.Property(e => e.ConfirmtextDe)
            .HasColumnType("text")
            .HasColumnName("confirmtext_de");
        builder.Property(e => e.ConfirmtextEn)
            .HasColumnType("text")
            .HasColumnName("confirmtext_en");
        builder.Property(e => e.ConfirmtextFr)
            .HasColumnType("text")
            .HasColumnName("confirmtext_fr");
        builder.Property(e => e.ConfirmtextNl)
            .HasColumnType("text")
            .HasColumnName("confirmtext_nl");
        builder.Property(e => e.Css)
            .HasMaxLength(255)
            .HasColumnName("css");
        builder.Property(e => e.InDatabase)
            .HasColumnType("int(1)")
            .HasColumnName("in_database");
        builder.Property(e => e.InMailinglist)
            .HasDefaultValueSql("'-1'")
            .HasColumnType("int(11)")
            .HasColumnName("in_mailinglist");
        builder.Property(e => e.IntrotextBe)
            .HasColumnType("text")
            .HasColumnName("introtext_be");
        builder.Property(e => e.IntrotextDe)
            .HasColumnType("text")
            .HasColumnName("introtext_de");
        builder.Property(e => e.IntrotextEn)
            .HasColumnType("text")
            .HasColumnName("introtext_en");
        builder.Property(e => e.IntrotextFr)
            .HasColumnType("text")
            .HasColumnName("introtext_fr");
        builder.Property(e => e.IntrotextNl)
            .HasColumnType("text")
            .HasColumnName("introtext_nl");
        builder.Property(e => e.Name)
            .HasMaxLength(64)
            .HasColumnName("name");
        builder.Property(e => e.Resultpage)
            .HasColumnType("text")
            .HasColumnName("resultpage");
        builder.Property(e => e.ResulttextBe)
            .HasColumnType("text")
            .HasColumnName("resulttext_be");
        builder.Property(e => e.ResulttextDe)
            .HasColumnType("text")
            .HasColumnName("resulttext_de");
        builder.Property(e => e.ResulttextEn)
            .HasColumnType("text")
            .HasColumnName("resulttext_en");
        builder.Property(e => e.ResulttextFr)
            .HasColumnType("text")
            .HasColumnName("resulttext_fr");
        builder.Property(e => e.ResulttextNl)
            .HasColumnType("text")
            .HasColumnName("resulttext_nl");
        builder.Property(e => e.ShowConfirmationpage)
            .HasColumnType("int(1)")
            .HasColumnName("show_confirmationpage");
        builder.Property(e => e.StandardCommunity)
            .HasColumnType("int(1)")
            .HasColumnName("standard_community");
        builder.Property(e => e.StandardMailinglist)
            .HasColumnType("int(1)")
            .HasColumnName("standard_mailinglist");
        builder.Property(e => e.TitleBe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_be");
        builder.Property(e => e.TitleDe)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_de");
        builder.Property(e => e.TitleEn)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_en");
        builder.Property(e => e.TitleFr)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_fr");
        builder.Property(e => e.TitleNl)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("title_nl");
        builder.Property(e => e.Type)
            .HasMaxLength(50)
            .HasColumnName("type");
        builder.Property(e => e.Width)
            .HasMaxLength(10)
            .HasColumnName("width");
    }
}
