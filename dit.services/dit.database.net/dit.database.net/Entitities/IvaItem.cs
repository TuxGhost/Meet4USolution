using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class IvaItem
{
    public ulong Id { get; set; }

    public ulong IvaId { get; set; }

    public string Dc { get; set; } = null!;

    public int Quantity { get; set; }

    public uint ProductId { get; set; }

    public uint Sku { get; set; }

    public string Description { get; set; } = null!;

    public float Excl { get; set; }

    public float Incl { get; set; }

    public float SumExcl { get; set; }

    public float SumIncl { get; set; }

    public string Account { get; set; } = null!;

    public string AccountRef { get; set; } = null!;

    public short TaxRateClassId { get; set; }

    public float Tax { get; set; }

    public float TaxAmount { get; set; }

    public bool TaxFree { get; set; }

    public string TaxAccount { get; set; } = null!;

    public string TaxAccountRef { get; set; } = null!;

    public sbyte IvaType { get; set; }

    public bool Active { get; set; }

    public bool Auto { get; set; }
}
