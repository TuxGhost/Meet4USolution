using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class DitcmsInfo
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string Value { get; set; } = null!;
}
