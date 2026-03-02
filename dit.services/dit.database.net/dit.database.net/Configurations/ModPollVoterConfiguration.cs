using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModPollVoterConfiguration : IEntityTypeConfiguration<ModPollVoter>
{
    public void Configure(EntityTypeBuilder<ModPollVoter> builder)
    {
        builder.HasKey(e => e.VoterId).HasName("PRIMARY");

        builder.ToTable("mod_poll_voter");

        builder.Property(e => e.VoterId)
            .HasColumnType("int(11)")
            .HasColumnName("voter_id");
        builder.Property(e => e.Ip)
            .HasMaxLength(15)
            .HasDefaultValueSql("'''0'''")
            .HasColumnName("ip");
        builder.Property(e => e.PollId)
            .HasColumnType("int(11)")
            .HasColumnName("poll_id");
        builder.Property(e => e.TimeLastVoted)
            .HasMaxLength(15)
            .HasDefaultValueSql("''''''")
            .HasColumnName("time_last_voted");
    }
}
