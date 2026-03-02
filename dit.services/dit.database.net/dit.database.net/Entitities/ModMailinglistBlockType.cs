using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistBlockType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string Template { get; set; } = null!;
}
