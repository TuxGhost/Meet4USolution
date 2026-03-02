using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModCommunityView
{
    public int InstanceId { get; set; }

    public string View { get; set; } = null!;
}
