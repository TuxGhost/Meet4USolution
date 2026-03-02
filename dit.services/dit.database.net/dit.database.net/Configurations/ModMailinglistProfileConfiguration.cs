using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dit.database.net.Configurations;

public class ModMailinglistProfileConfiguration : IEntityTypeConfiguration<ModMailinglistProfile>
{
    public void Configure(EntityTypeBuilder<ModMailinglistProfile> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_profiles");

        builder.HasIndex(e => e.MailinglistId, "mailinglist_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Custom)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("custom");
        builder.Property(e => e.ExternId)
            .HasColumnType("smallint(6)")
            .HasColumnName("extern_id");
        builder.Property(e => e.MailinglistId)
            .HasColumnType("int(11)")
            .HasColumnName("mailinglist_id");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasColumnName("name");
    }
}
