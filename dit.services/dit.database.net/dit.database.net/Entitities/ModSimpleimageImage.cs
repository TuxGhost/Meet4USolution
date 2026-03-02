using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModSimpleimageImage
{
    public int ImageId { get; set; }

    public int ModuleId { get; set; }

    public string Photo { get; set; } = null!;

    public int Sort { get; set; }

    public string UrlDe { get; set; } = null!;

    public string TargetDe { get; set; } = null!;

    public string TitleDe { get; set; } = null!;

    public string DescriptionDe { get; set; } = null!;

    public bool VisibleDe { get; set; }

    public string UrlEn { get; set; } = null!;

    public string TargetEn { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;

    public bool VisibleEn { get; set; }

    public string UrlNl { get; set; } = null!;

    public string TargetNl { get; set; } = null!;

    public string TitleNl { get; set; } = null!;

    public string DescriptionNl { get; set; } = null!;

    public bool VisibleNl { get; set; }

    public string UrlFr { get; set; } = null!;

    public string TargetFr { get; set; } = null!;

    public string TitleFr { get; set; } = null!;

    public string DescriptionFr { get; set; } = null!;

    public bool VisibleFr { get; set; }

    public string UrlBe { get; set; } = null!;

    public string TargetBe { get; set; } = null!;

    public string TitleBe { get; set; } = null!;

    public string DescriptionBe { get; set; } = null!;

    public bool VisibleBe { get; set; }
}
