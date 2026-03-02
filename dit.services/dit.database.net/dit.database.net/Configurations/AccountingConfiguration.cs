using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class AccountingConfiguration : IEntityTypeConfiguration<Accounting>
{
    public void Configure(EntityTypeBuilder<Accounting> builder)
    {
        builder.HasKey(e => e.Number).HasName("PRIMARY");

        builder.ToTable("accounting");

        builder.Property(e => e.Number)
            .HasMaxLength(10)
            .HasColumnName("number");
        builder.Property(e => e.Description)
            .HasColumnType("text")
            .HasColumnName("description");
    }
}
