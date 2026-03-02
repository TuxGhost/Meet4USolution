using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistEasyblock
{
    public int Id { get; set; }

    public int EasymailId { get; set; }

    public string Type { get; set; } = null!;

    public int Sort { get; set; }

    public string Data { get; set; } = null!;
}
