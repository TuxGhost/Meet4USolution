using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModPollTranslation
{
    public int TranslationId { get; set; }

    public int Id { get; set; }

    public string LangCode { get; set; } = null!;

    public string Translation { get; set; } = null!;

    public string Type { get; set; } = null!;
}
