using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class WebsiteRight
{
    public int Id { get; set; }

    public int Groupid { get; set; }

    public string Website { get; set; } = null!;

    public int Access { get; set; }
}
