using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModCommunityTemplateModuleinstance
{
    public int Id { get; set; }

    public string Template { get; set; } = null!;

    public int Moduleinstanceid { get; set; }

    public int Ordernumber { get; set; }

    public string Websitename { get; set; } = null!;

    public int Orderme { get; set; }
}
