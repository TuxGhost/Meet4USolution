using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubEventOrganisator
{
    public uint EventId { get; set; }

    public uint UserId { get; set; }

    public virtual ModClubEvent Event { get; set; } = null!;
}
