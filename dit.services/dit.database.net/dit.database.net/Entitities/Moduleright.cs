using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Moduleright
{
    public int Id { get; set; }

    public int Groupid { get; set; }

    public int Moduleinstanceid { get; set; }

    public int Access { get; set; }
}
