using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Mailtemplate
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Replacevars { get; set; }
}
