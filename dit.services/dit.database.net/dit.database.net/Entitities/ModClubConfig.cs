using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubConfig
{
    public uint Id { get; set; }

    public decimal PriceRegfee { get; set; }

    public decimal PriceSub { get; set; }

    public decimal PriceSubDigi { get; set; }

    public string PdfFriends { get; set; } = null!;

    public string PdfPlus { get; set; } = null!;
}
