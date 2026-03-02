using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModFormChoice
{
    public int ChoiceId { get; set; }

    public int FieldId { get; set; }

    public string Value { get; set; } = null!;

    public int Selected { get; set; }

    public int Sort { get; set; }

    public string NameDe { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameNl { get; set; } = null!;

    public string NameFr { get; set; } = null!;

    public string NameBe { get; set; } = null!;
}
