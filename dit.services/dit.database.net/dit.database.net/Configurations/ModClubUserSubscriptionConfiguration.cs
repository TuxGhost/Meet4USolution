using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubUserSubscriptionConfiguration : IEntityTypeConfiguration<ModClubUserSubscription>
{
    public void Configure(EntityTypeBuilder<ModClubUserSubscription> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_user_subscription");

        builder.HasIndex(e => new { e.DateFrom, e.DateTo }, "date_from");

        builder.HasIndex(e => e.UserId, "user_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.DateFrom)
            .HasColumnType("date")
            .HasColumnName("date_from");
        builder.Property(e => e.DateTo)
            .HasColumnType("date")
            .HasColumnName("date_to");
        builder.Property(e => e.Digi).HasColumnName("digi");
        builder.Property(e => e.Trial)
            .HasComment("Proef periode")
            .HasColumnName("trial");
        builder.Property(e => e.UserId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("user_id");

        builder.HasOne(d => d.User).WithMany(p => p.ModClubUserSubscriptions)
            .HasForeignKey(d => d.UserId)
            .HasConstraintName("mod_club_user_subscription_ibfk_1");
    }
}
