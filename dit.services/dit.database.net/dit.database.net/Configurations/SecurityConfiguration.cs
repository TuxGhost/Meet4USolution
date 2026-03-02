using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class SecurityConfiguration : IEntityTypeConfiguration<Security>
{
    public void Configure(EntityTypeBuilder<Security> builder)
    {
        builder.HasKey(e => e.SecurityId).HasName("PRIMARY");

        builder.ToTable("security");

        builder.Property(e => e.SecurityId)
            .HasColumnType("int(11)")
            .HasColumnName("security_id");
        builder.Property(e => e.Active).HasColumnName("active");
    }
}
