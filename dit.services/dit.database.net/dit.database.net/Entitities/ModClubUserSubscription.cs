using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubUserSubscription
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public bool Digi { get; set; }

    /// <summary>
    /// Proef periode
    /// </summary>
    public bool Trial { get; set; }

    public virtual ModClubUser User { get; set; } = null!;
}
