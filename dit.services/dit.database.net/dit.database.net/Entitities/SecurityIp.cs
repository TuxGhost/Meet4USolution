using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class SecurityIp
{
    public uint SecurityIpId { get; set; }

    public uint SecurityId { get; set; }

    public uint Ip { get; set; }

    public bool Protected { get; set; }

    public string Description { get; set; } = null!;
}
