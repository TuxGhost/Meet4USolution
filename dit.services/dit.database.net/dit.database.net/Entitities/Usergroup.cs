using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Usergroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool System { get; set; }
}
