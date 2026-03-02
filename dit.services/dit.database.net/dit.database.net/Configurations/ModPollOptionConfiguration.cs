using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModPollOptionConfiguration : IEntityTypeConfiguration<ModPollOption>
{
    public void Configure(EntityTypeBuilder<ModPollOption> builder)
    {
        builder.HasKey(e => e.OptionId).HasName("PRIMARY");

        builder.ToTable("mod_poll_option");

        builder.Property(e => e.OptionId)
            .HasColumnType("int(11)")
            .HasColumnName("option_id");
        builder.Property(e => e.Count)
            .HasColumnType("int(11)")
            .HasColumnName("count");
        builder.Property(e => e.PollId)
            .HasColumnType("int(11)")
            .HasColumnName("poll_id");
        builder.Property(e => e.Sort)
            .HasColumnType("int(10)")
            .HasColumnName("sort");
    }
}
