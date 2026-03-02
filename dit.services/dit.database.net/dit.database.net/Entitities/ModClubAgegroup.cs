using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubAgegroup
{
    public uint Id { get; set; }

    /// <summary>
    /// Leeftijd van
    /// </summary>
    public int AgeFrom { get; set; }

    /// <summary>
    /// Leeftijd t/m
    /// </summary>
    public int AgeTo { get; set; }

    /// <summary>
    /// a, b, c, d, e, f, etc.
    /// </summary>
    public string NameNl { get; set; } = null!;

    /// <summary>
    /// 0: Friends, 1: Plus
    /// </summary>
    public bool Type { get; set; }

    public int ProfileId { get; set; }

    public virtual ICollection<ModClubWallpost> ModClubWallposts { get; set; } = new List<ModClubWallpost>();

    public virtual ICollection<ModClubEvent> Events { get; set; } = new List<ModClubEvent>();

    public virtual ICollection<ModClubWallpost> Wallposts { get; set; } = new List<ModClubWallpost>();
}
