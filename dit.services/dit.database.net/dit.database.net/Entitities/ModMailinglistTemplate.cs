using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistTemplate
{
    public int Id { get; set; }

    public bool? Active { get; set; }

    public string Name { get; set; } = null!;

    public string Content { get; set; } = null!;
}
