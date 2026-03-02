using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ManualBarcode
{
    public string Type { get; set; } = null!;

    public ulong Number { get; set; }
}
