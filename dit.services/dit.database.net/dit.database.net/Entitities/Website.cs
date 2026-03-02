using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Website
{
    public string Name { get; set; } = null!;

    public string Creator { get; set; } = null!;

    public string Template { get; set; } = null!;

    public string Css { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Sitemap { get; set; } = null!;

    public bool Default { get; set; }

    public byte Status { get; set; }

    public bool BrowserSpecificStyle { get; set; }

    public byte BrowserDetection { get; set; }

    public string DefaultLanguage { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Keywords { get; set; }

    public string? Description { get; set; }

    public string TitleEn { get; set; } = null!;

    public string? KeywordsEn { get; set; }

    public string? DescriptionEn { get; set; }
}
