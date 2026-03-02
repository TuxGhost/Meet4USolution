using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModLinksLink
{
    public int LinkId { get; set; }

    public int LinksId { get; set; }

    public bool? Active { get; set; }

    public string LinkTarget { get; set; } = null!;

    public string Class { get; set; } = null!;

    public string Rel { get; set; } = null!;

    public int SortOrder { get; set; }

    public string? Image { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime LastModified { get; set; }

    public string TitleNl { get; set; } = null!;

    public string DescriptionNl { get; set; } = null!;

    public string UrlNl { get; set; } = null!;

    public bool? VisibleNl { get; set; }

    public string TitleEn { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;

    public string UrlEn { get; set; } = null!;

    public bool? VisibleEn { get; set; }

    public string TitleDe { get; set; } = null!;

    public string DescriptionDe { get; set; } = null!;

    public string UrlDe { get; set; } = null!;

    public bool? VisibleDe { get; set; }

    public string TitleFr { get; set; } = null!;

    public string DescriptionFr { get; set; } = null!;

    public string UrlFr { get; set; } = null!;

    public bool? VisibleFr { get; set; }

    public string TitleBe { get; set; } = null!;

    public string DescriptionBe { get; set; } = null!;

    public string UrlBe { get; set; } = null!;

    public bool? VisibleBe { get; set; }
}
