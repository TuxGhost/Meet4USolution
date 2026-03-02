using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubTag
{
    public uint Id { get; set; }

    /// <summary>
    /// System tags, can&apos;t be removed.
    /// </summary>
    public bool System { get; set; }

    public string NameNl { get; set; } = null!;

    public virtual ICollection<ModClubEvent> Events { get; set; } = new List<ModClubEvent>();
}
