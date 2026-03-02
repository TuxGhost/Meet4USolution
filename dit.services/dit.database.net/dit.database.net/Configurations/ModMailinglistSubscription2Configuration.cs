using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistSubscription2Configuration : IEntityTypeConfiguration<ModMailinglistSubscription2>
{
    public void Configure(EntityTypeBuilder<ModMailinglistSubscription2> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist_subscription2");

        builder.HasIndex(e => e.Dirty, "dirty");

        builder.HasIndex(e => new { e.Email, e.Zipcode, e.Housenumber, e.MailinglistId }, "email").IsUnique();

        builder.HasIndex(e => e.MailinglistId, "mailinglist_id");

        builder.HasIndex(e => e.SubEmail, "sub_email");

        builder.HasIndex(e => e.SubMail, "sub_mail");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Address)
            .HasMaxLength(128)
            .HasColumnName("address");
        builder.Property(e => e.City)
            .HasMaxLength(64)
            .HasColumnName("city");
        builder.Property(e => e.CountryId)
            .HasMaxLength(2)
            .HasColumnName("country_id");
        builder.Property(e => e.Dirty).HasColumnName("dirty");
        builder.Property(e => e.Dob)
            .HasDefaultValueSql("'''0000-00-00'''")
            .HasColumnType("date")
            .HasColumnName("dob");
        builder.Property(e => e.Email).HasColumnName("email");
        builder.Property(e => e.Firstname)
            .HasMaxLength(255)
            .HasColumnName("firstname");
        builder.Property(e => e.Gender)
            .HasMaxLength(1)
            .HasColumnName("gender");
        builder.Property(e => e.Housenumber)
            .HasMaxLength(10)
            .HasColumnName("housenumber");
        builder.Property(e => e.Initials)
            .HasMaxLength(10)
            .HasColumnName("initials");
        builder.Property(e => e.Lastname)
            .HasMaxLength(255)
            .HasColumnName("lastname");
        builder.Property(e => e.MailinglistId)
            .HasColumnType("int(11)")
            .HasColumnName("mailinglist_id");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasColumnName("name");
        builder.Property(e => e.Register)
            .HasMaxLength(32)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("register");
        builder.Property(e => e.ShopUserId)
            .HasColumnType("int(11)")
            .HasColumnName("shop_user_id");
        builder.Property(e => e.Signupform)
            .HasColumnType("int(11)")
            .HasColumnName("signupform");
        builder.Property(e => e.Signupformid)
            .HasColumnType("int(11)")
            .HasColumnName("signupformid");
        builder.Property(e => e.SubEmail).HasColumnName("sub_email");
        builder.Property(e => e.SubMail).HasColumnName("sub_mail");
        builder.Property(e => e.SubscriptionLanguage)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("subscription_language");
        builder.Property(e => e.Zipcode)
            .HasMaxLength(10)
            .HasColumnName("zipcode");
    }
}
