using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Moduleinstance
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Moduleid { get; set; }

    public string View { get; set; } = null!;

    public string Config { get; set; } = null!;
}
