using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class LanguageSite
{
    public string Code { get; set; } = null!;

    public string Website { get; set; } = null!;

    public int Defaultlan { get; set; }
}
