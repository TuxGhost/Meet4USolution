using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Pageview
{
    public int Id { get; set; }

    public string? Ip { get; set; }

    public int Page { get; set; }

    public DateTime Date { get; set; }

    public string Siteid { get; set; } = null!;
}
