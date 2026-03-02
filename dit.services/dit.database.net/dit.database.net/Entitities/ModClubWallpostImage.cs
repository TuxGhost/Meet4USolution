using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubWallpostImage
{
    public uint Id { get; set; }

    public uint WallpostId { get; set; }

    public string Image { get; set; } = null!;

    public bool IsFile { get; set; }

    public int Sort { get; set; }

    public virtual ModClubWallpost Wallpost { get; set; } = null!;
}
