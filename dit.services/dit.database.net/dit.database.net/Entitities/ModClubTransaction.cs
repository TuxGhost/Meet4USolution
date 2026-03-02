using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubTransaction
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public float Amount { get; set; }

    public string Type { get; set; } = null!;

    public uint TypeId { get; set; }

    public string Prices { get; set; } = null!;

    public string PaymentSession { get; set; } = null!;

    public string PaymentMethod { get; set; } = null!;

    public string ProviderStatus { get; set; } = null!;

    public string TransactionId { get; set; } = null!;

    public DateTime DatePaid { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public virtual ModClubUser User { get; set; } = null!;
}
