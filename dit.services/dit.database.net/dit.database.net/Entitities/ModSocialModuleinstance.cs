using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModSocialModuleinstance
{
    public int ModuleinstanceId { get; set; }

    public string View { get; set; } = null!;

    public string Config { get; set; } = null!;
}
