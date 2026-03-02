using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubEventMembertype
{
    public uint EventId { get; set; }

    /// <summary>
    /// 0: Aspirant, 1: Lid, 2: Oud Lid
    /// </summary>
    public string Type { get; set; } = null!;

    public virtual ModClubEvent Event { get; set; } = null!;
}
