using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class PageModuleinstance
{
    public int Id { get; set; }

    public int Pageid { get; set; }

    public int Moduleinstanceid { get; set; }

    public int Ordernumber { get; set; }

    public string Websitename { get; set; } = null!;

    public int Orderme { get; set; }
}
