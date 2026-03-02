using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModMailinglistConfiguration : IEntityTypeConfiguration<ModMailinglist>
{
    public void Configure(EntityTypeBuilder<ModMailinglist> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_mailinglist");

        builder.Property(e => e.Id)
            .HasColumnType("int(11)")
            .HasColumnName("id");
        builder.Property(e => e.Communitygroup)
            .HasDefaultValueSql("'0'")
            .HasColumnType("int(11)")
            .HasColumnName("communitygroup");
        builder.Property(e => e.DefaultSendfrom)
            .HasMaxLength(255)
            .HasColumnName("default_sendfrom");
        builder.Property(e => e.DefaultSendfromName)
            .HasMaxLength(255)
            .HasColumnName("default_sendfrom_name");
        builder.Property(e => e.DefaultSendto)
            .HasDefaultValueSql("'-42'")
            .HasColumnType("int(11)")
            .HasColumnName("default_sendto");
        builder.Property(e => e.DefaultSubject)
            .HasMaxLength(255)
            .HasColumnName("default_subject");
        builder.Property(e => e.DefaultTemplate)
            .HasDefaultValueSql("'-42'")
            .HasColumnType("int(11)")
            .HasColumnName("default_template");
        builder.Property(e => e.DefaultTestaddress)
            .HasMaxLength(255)
            .HasColumnName("default_testaddress");
        builder.Property(e => e.Mailinglistserver)
            .HasDefaultValueSql("'-1'")
            .HasColumnType("int(11)")
            .HasColumnName("mailinglistserver");
        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasDefaultValueSql("'NULL'")
            .HasColumnName("name");
        builder.Property(e => e.PeriodDate)
            .HasDefaultValueSql("'1'")
            .HasColumnType("int(2)")
            .HasColumnName("period_date");
        builder.Property(e => e.PeriodInterval)
            .HasColumnType("int(1)")
            .HasColumnName("period_interval");
        builder.Property(e => e.Periodic)
            .HasColumnType("int(1)")
            .HasColumnName("periodic");
        builder.Property(e => e.Signupform)
            .HasDefaultValueSql("'0'")
            .HasColumnType("int(11)")
            .HasColumnName("signupform");
        builder.Property(e => e.Signupmoduleid)
            .HasColumnType("int(10)")
            .HasColumnName("signupmoduleid");
    }
}
