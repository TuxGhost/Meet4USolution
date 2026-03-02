using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Page
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Template { get; set; } = null!;

    public DateTime? Date { get; set; }

    public int? Ignorewebsitetemplate { get; set; }

    public string? Css { get; set; }
}
