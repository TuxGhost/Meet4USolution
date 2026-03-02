using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModForumCategory
{
    public int CategoryId { get; set; }

    public int MainforumId { get; set; }

    public string Name { get; set; } = null!;

    public int Sort { get; set; }
}
