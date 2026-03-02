using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Sitemapobject
{
    public int Id { get; set; }

    public string Websitename { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Parent { get; set; }

    public string? Link { get; set; }

    public string Target { get; set; } = null!;

    public int Visible { get; set; }

    public int Ishomepage { get; set; }

    public int Isfrontpage { get; set; }

    public int Orderme { get; set; }

    public string Config { get; set; } = null!;
}
