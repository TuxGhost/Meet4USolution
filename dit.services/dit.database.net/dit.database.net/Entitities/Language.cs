using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Language
{
    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string DescriptionNl { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;
}
