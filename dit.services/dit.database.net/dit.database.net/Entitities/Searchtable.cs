using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Searchtable
{
    public int Id { get; set; }

    public int Moduleid { get; set; }

    public string Tablename { get; set; } = null!;

    public string Fieldname { get; set; } = null!;
}
