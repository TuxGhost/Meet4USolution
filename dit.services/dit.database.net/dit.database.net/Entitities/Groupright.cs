using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Groupright
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Groupid { get; set; }

    public int Access { get; set; }
}
