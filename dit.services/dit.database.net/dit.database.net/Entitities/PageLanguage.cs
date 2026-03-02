using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class PageLanguage
{
    public int Id { get; set; }

    public string Languageid { get; set; } = null!;

    public string Keywords { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Image { get; set; } = null!;
}
