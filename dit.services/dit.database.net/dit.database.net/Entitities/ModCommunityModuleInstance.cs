using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModCommunityModuleInstance
{
    public int Id { get; set; }

    public int? Moduleid { get; set; }

    public string? Menuname { get; set; }

    public int? Linktoinstanceid { get; set; }

    public int? Moduleinstanceid { get; set; }

    public string? Website { get; set; }
}
