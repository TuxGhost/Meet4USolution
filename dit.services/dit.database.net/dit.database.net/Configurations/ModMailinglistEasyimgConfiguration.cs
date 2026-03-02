using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistEasyimgConfiguration : IEntityTypeConfiguration<ModMailinglistEasyimg>
{
    public void Configure(EntityTypeBuilder<ModMailinglistEasyimg> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_easyimg");

        builder.Property(e => e.Id)
            .HasColumnType("int(10)")
            .HasColumnName("id");
        builder.Property(e => e.EasymailId)
            .HasColumnType("int(10)")
            .HasColumnName("easymail_id");
        builder.Property(e => e.JcH)
            .HasColumnType("int(11)")
            .HasColumnName("jc_h");
        builder.Property(e => e.JcW)
            .HasColumnType("int(11)")
            .HasColumnName("jc_w");
        builder.Property(e => e.JcX)
            .HasColumnType("int(11)")
            .HasColumnName("jc_x");
        builder.Property(e => e.JcY)
            .HasColumnType("int(11)")
            .HasColumnName("jc_y");
        builder.Property(e => e.Location)
            .HasMaxLength(255)
            .HasColumnName("location");
        builder.Property(e => e.Sort)
            .HasColumnType("int(2)")
            .HasColumnName("sort");
        builder.Property(e => e.Text)
            .HasColumnType("text")
            .HasColumnName("text");
    }
}
