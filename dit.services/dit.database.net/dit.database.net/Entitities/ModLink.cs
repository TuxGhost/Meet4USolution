using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModLink
{
    public uint LinksId { get; set; }

    public bool? ShowTitle { get; set; }

    public string ListElement { get; set; } = null!;

    public string ListClass { get; set; } = null!;

    public string TitleElement { get; set; } = null!;

    public string TitleClass { get; set; } = null!;

    public string SortOn { get; set; } = null!;

    public string SortOrder { get; set; } = null!;

    public string TitleNl { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string TitleDe { get; set; } = null!;

    public string TitleFr { get; set; } = null!;

    public string TitleBe { get; set; } = null!;
}
