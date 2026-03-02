using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class PageModuleinstanceConfiguration : IEntityTypeConfiguration<PageModuleinstance>
{
    public void Configure(EntityTypeBuilder<PageModuleinstance> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("page_moduleinstance");

        builder.HasIndex(e => e.Pageid, "pageid");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Moduleinstanceid)
            .HasColumnType("int(11)")
            .HasColumnName("moduleinstanceid");
        builder.Property(e => e.Orderme)
            .HasColumnType("int(11)")
            .HasColumnName("orderme");
        builder.Property(e => e.Ordernumber)
            .HasColumnType("int(11)")
            .HasColumnName("ordernumber");
        builder.Property(e => e.Pageid)
            .HasColumnType("int(11)")
            .HasColumnName("pageid");
        builder.Property(e => e.Websitename)
            .HasMaxLength(255)
            .HasDefaultValueSql("''''''")
            .HasColumnName("websitename");
    }
}
