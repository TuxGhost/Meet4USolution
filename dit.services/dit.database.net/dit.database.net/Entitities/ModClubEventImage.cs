using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubEventImage
{
    public uint Id { get; set; }

    public uint EventId { get; set; }

    public string Image { get; set; } = null!;

    public int Sort { get; set; }

    public virtual ModClubEvent Event { get; set; } = null!;
}
