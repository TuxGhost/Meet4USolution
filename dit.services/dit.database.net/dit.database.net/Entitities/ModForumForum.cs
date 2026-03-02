using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModForumForum
{
    public int ForumId { get; set; }

    public int CategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Sort { get; set; }

    public int Status { get; set; }
}
