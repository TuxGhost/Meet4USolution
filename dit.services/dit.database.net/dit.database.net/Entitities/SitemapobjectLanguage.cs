using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class SitemapobjectLanguage
{
    public int Id { get; set; }

    public int Sitemapid { get; set; }

    public string Languageid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Alias { get; set; }

    public string Image { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? Visible { get; set; }
}
