using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModArticlesChangelog
{
    public int ChangelogId { get; set; }

    public int ArticleId { get; set; }

    public int ArticlesId { get; set; }

    public int UserId { get; set; }

    public string Author { get; set; } = null!;

    public string Language { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Type { get; set; } = null!;

    public string Comments { get; set; } = null!;
}
