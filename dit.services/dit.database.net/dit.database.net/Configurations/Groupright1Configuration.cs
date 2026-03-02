using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class Groupright1Configuration : IEntityTypeConfiguration<Groupright1>
{
    public void Configure(EntityTypeBuilder<Groupright1> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("grouprights");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("name");
    }
}
