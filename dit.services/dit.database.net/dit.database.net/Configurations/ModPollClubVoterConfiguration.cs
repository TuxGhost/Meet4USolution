using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModPollClubVoterConfiguration : IEntityTypeConfiguration<ModPollClubVoter>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ModPollClubVoter> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_poll_club_voter");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.ClubUserId)
            .HasColumnType("int(11)")
            .HasColumnName("club_user_id");
        builder.Property(e => e.PollId)
            .HasColumnType("int(11)")
            .HasColumnName("poll_id");
        builder.Property(e => e.TimeLastVoted)
            .HasMaxLength(15)
            .HasDefaultValueSql("''''''")
            .HasColumnName("time_last_voted");
    }
}
