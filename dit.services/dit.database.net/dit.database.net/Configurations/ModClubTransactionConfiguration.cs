using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubTransactionConfiguration : IEntityTypeConfiguration<ModClubTransaction>
{
    public void Configure(EntityTypeBuilder<ModClubTransaction> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_transaction");

        builder.HasIndex(e => e.TransactionId, "transaction_id");

        builder.HasIndex(e => new { e.Type, e.TypeId }, "type");

        builder.HasIndex(e => e.UserId, "user_id");

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Amount)
            .HasColumnType("float(14,2)")
            .HasColumnName("amount");
        builder.Property(e => e.DateCreated)
            .HasColumnType("datetime")
            .HasColumnName("date_created");
        builder.Property(e => e.DateModified)
            .HasColumnType("datetime")
            .HasColumnName("date_modified");
        builder.Property(e => e.DatePaid)
            .HasColumnType("datetime")
            .HasColumnName("date_paid");
        builder.Property(e => e.PaymentMethod)
            .HasMaxLength(32)
            .HasColumnName("payment_method");
        builder.Property(e => e.PaymentSession)
            .HasMaxLength(64)
            .HasColumnName("payment_session");
        builder.Property(e => e.Prices)
            .HasColumnType("text")
            .HasColumnName("prices");
        builder.Property(e => e.ProviderStatus)
            .HasMaxLength(32)
            .HasColumnName("provider_status");
        builder.Property(e => e.TransactionId).HasColumnName("transaction_id");
        builder.Property(e => e.Type)
            .HasColumnType("enum('sub','sub_digi','event')")
            .HasColumnName("type");
        builder.Property(e => e.TypeId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("type_id");
        builder.Property(e => e.UserId)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("user_id");

        builder.HasOne(d => d.User).WithMany(p => p.ModClubTransactions)
            .HasForeignKey(d => d.UserId)
            .HasConstraintName("mod_club_transaction_ibfk_1");
    }
}
