using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistEasymailConfiguration : IEntityTypeConfiguration<ModMailinglistEasymail>
{
    public void Configure(EntityTypeBuilder<ModMailinglistEasymail> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_easymails");

        builder.HasIndex(e => e.Pricelist, "pricelist");

        builder.Property(e => e.Id)
            .HasColumnType("int(10)")
            .HasColumnName("id");
        builder.Property(e => e.ImageWidth)
            .HasColumnType("smallint(6)")
            .HasColumnName("image_width");
        builder.Property(e => e.Modified)
            .HasColumnType("datetime")
            .HasColumnName("modified");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasColumnName("name");
        builder.Property(e => e.Pricelist)
            .HasMaxLength(48)
            .HasColumnName("pricelist");
        builder.Property(e => e.Product)
            .HasColumnType("text")
            .HasColumnName("product");
        builder.Property(e => e.Senderemail)
            .HasMaxLength(255)
            .HasColumnName("senderemail");
        builder.Property(e => e.Sendername)
            .HasMaxLength(255)
            .HasColumnName("sendername");
        builder.Property(e => e.SubTitle)
            .HasColumnType("text")
            .HasColumnName("sub_title");
        builder.Property(e => e.TemplateId)
            .HasColumnType("int(10)")
            .HasColumnName("template_id");
        builder.Property(e => e.Text1De)
            .HasColumnType("text")
            .HasColumnName("text_1_de");
        builder.Property(e => e.Text1En)
            .HasColumnType("text")
            .HasColumnName("text_1_en");
        builder.Property(e => e.Text1Nl)
            .HasColumnType("text")
            .HasColumnName("text_1_nl");
        builder.Property(e => e.Text2De)
            .HasColumnType("text")
            .HasColumnName("text_2_de");
        builder.Property(e => e.Text2En)
            .HasColumnType("text")
            .HasColumnName("text_2_en");
        builder.Property(e => e.Text2Nl)
            .HasColumnType("text")
            .HasColumnName("text_2_nl");
        builder.Property(e => e.Text3De)
            .HasColumnType("text")
            .HasColumnName("text_3_de");
        builder.Property(e => e.Text3En)
            .HasColumnType("text")
            .HasColumnName("text_3_en");
        builder.Property(e => e.Text3Nl)
            .HasColumnType("text")
            .HasColumnName("text_3_nl");
        builder.Property(e => e.TitleDe)
            .HasColumnType("text")
            .HasColumnName("title_de");
        builder.Property(e => e.TitleEn)
            .HasColumnType("text")
            .HasColumnName("title_en");
        builder.Property(e => e.TitleNl)
            .HasColumnType("text")
            .HasColumnName("title_nl");
    }
}
