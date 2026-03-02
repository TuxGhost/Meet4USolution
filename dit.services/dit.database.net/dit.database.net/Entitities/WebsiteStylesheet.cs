using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class WebsiteStylesheet
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string Browser { get; set; } = null!;

    public decimal VersionFrom { get; set; }

    public decimal VersionTo { get; set; }

    public string Stylesheet { get; set; } = null!;
}
