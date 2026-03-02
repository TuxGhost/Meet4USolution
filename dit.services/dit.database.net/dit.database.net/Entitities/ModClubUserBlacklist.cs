using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubUserBlacklist
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    /// <summary>
    /// Reden
    /// </summary>
    public string Comment { get; set; } = null!;
}
