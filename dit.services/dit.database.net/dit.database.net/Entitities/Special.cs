using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Special
{
    public uint Id { get; set; }

    public bool Active { get; set; }

    public string NameEn { get; set; } = null!;

    public string AliasEn { get; set; } = null!;
}
