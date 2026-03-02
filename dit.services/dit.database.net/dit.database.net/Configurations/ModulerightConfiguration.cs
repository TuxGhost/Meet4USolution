using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModulerightConfiguration : IEntityTypeConfiguration<Moduleright>
{
    public void Configure(EntityTypeBuilder<Moduleright> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("moduleright");

        builder.HasIndex(e => e.Groupid, "groupid");

        builder.HasIndex(e => e.Moduleinstanceid, "moduleinstanceid");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Access)
            .HasColumnType("int(2)")
            .HasColumnName("access");
        builder.Property(e => e.Groupid)
            .HasColumnType("int(11)")
            .HasColumnName("groupid");
        builder.Property(e => e.Moduleinstanceid)
            .HasColumnType("int(11)")
            .HasColumnName("moduleinstanceid");
    }
}
