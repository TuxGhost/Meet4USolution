using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistProfilingSubscriptionConfiguration : IEntityTypeConfiguration<ModMailinglistProfilingSubscription>
{
    public void Configure(EntityTypeBuilder<ModMailinglistProfilingSubscription> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_profiling_subscription");

        builder.HasIndex(e => e.Hash, "hash");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Hash)
            .HasMaxLength(128)
            .HasDefaultValueSql("''''''")
            .HasColumnName("hash");
        builder.Property(e => e.SubscriptionId)
            .HasColumnType("int(11)")
            .HasColumnName("subscription_id");
    }
}
