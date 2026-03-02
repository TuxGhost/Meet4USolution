using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModArticlesTag
{
    public int TagId { get; set; }

    public int ArticlesId { get; set; }

    public string Language { get; set; } = null!;

    public string Tag { get; set; } = null!;
}
