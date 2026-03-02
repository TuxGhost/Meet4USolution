using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistEasyimg
{
    public int Id { get; set; }

    public int EasymailId { get; set; }

    public string Location { get; set; } = null!;

    public string Text { get; set; } = null!;

    public int Sort { get; set; }

    public int JcX { get; set; }

    public int JcY { get; set; }

    public int JcW { get; set; }

    public int JcH { get; set; }
}
