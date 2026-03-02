using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistEasyblockConfiguration : IEntityTypeConfiguration<ModMailinglistEasyblock>
{
    public void Configure(EntityTypeBuilder<ModMailinglistEasyblock> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_easyblock");

        builder.HasIndex(e => e.EasymailId, "mailinglist_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(10)")
            .HasColumnName("id");
        builder.Property(e => e.Data)
            .HasColumnType("text")
            .HasColumnName("data");
        builder.Property(e => e.EasymailId)
            .HasColumnType("int(10)")
            .HasColumnName("easymail_id");
        builder.Property(e => e.Sort)
            .HasColumnType("int(2)")
            .HasColumnName("sort");
        builder.Property(e => e.Type)
            .HasMaxLength(16)
            .HasColumnName("type");
    }
}
