using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class SocialResponse
{
    public ulong Id { get; set; }

    public string Module { get; set; } = null!;

    public ulong InstanceId { get; set; }

    public string Link { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string Network { get; set; } = null!;
}
