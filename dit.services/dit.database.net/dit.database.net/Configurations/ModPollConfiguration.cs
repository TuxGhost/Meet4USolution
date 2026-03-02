using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModPollConfiguration : IEntityTypeConfiguration<ModPoll>
{
    public void Configure(EntityTypeBuilder<ModPoll> builder)
    {
        builder.HasKey(e => e.PollId).HasName("PRIMARY");

        builder.ToTable("mod_poll");

        builder.Property(e => e.PollId)
            .HasColumnType("int(11)")
            .HasColumnName("poll_id");
        builder.Property(e => e.Active)
            .HasColumnType("int(1)")
            .HasColumnName("active");
        builder.Property(e => e.DateEnd)
            .HasColumnType("date")
            .HasColumnName("date_end");
        builder.Property(e => e.DateStart)
            .HasColumnType("date")
            .HasColumnName("date_start");
        builder.Property(e => e.VoteTime)
            .HasColumnType("int(5)")
            .HasColumnName("vote_time");
    }
}
