using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistProfilesSubscriptionConfiguration : IEntityTypeConfiguration<ModMailinglistProfilesSubscription>
{
    public void Configure(EntityTypeBuilder<ModMailinglistProfilesSubscription> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_profiles_subscription");

        builder.HasIndex(e => new { e.ProfileId, e.SubscriptionId }, "profile_id").IsUnique();

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.ProfileId)
            .HasColumnType("int(11)")
            .HasColumnName("profile_id");
        builder.Property(e => e.SubscriptionId)
            .HasColumnType("int(11)")
            .HasColumnName("subscription_id");
    }
}
