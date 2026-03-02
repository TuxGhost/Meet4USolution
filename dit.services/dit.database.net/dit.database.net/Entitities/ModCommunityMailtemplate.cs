using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModCommunityMailtemplate
{
    public int TemplateId { get; set; }

    public string Name { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string Css { get; set; } = null!;

    public string Language { get; set; } = null!;
}
