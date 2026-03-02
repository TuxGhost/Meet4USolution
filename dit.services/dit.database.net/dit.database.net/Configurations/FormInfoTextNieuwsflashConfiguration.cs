using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class FormInfoTextNieuwsflashConfiguration : IEntityTypeConfiguration<FormInfoTekstNieuwsflash>
{
    public void Configure(EntityTypeBuilder<FormInfoTekstNieuwsflash> builder)
    {
        builder.HasKey(e => e.InfoTekstNieuwsflashId).HasName("PRIMARY");

        builder.ToTable("form_info_tekst_nieuwsflash");

        builder.Property(e => e.InfoTekstNieuwsflashId)
            .HasColumnType("int(11)")
            .HasColumnName("info_tekst_nieuwsflash_id");
    }
}
