using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Favorite
{
    public uint Id { get; set; }

    public string Link { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public bool Active { get; set; }

    public byte Order { get; set; }

    public bool AccessType { get; set; }

    public string AccessCheck { get; set; } = null!;

    public string DescriptionNl { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;
}
