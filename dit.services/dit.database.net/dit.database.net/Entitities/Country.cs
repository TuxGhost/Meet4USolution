using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Country
{
    public string Id { get; set; } = null!;

    public string IsoReference { get; set; } = null!;

    public string IsoReferenceFr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string SynEn { get; set; } = null!;

    public string NameFr { get; set; } = null!;

    public string SynFr { get; set; } = null!;

    public string NameNl { get; set; } = null!;

    public string SynNl { get; set; } = null!;

    public string NameDe { get; set; } = null!;

    public string SynDe { get; set; } = null!;

    public bool IsEu { get; set; }

    public string Continent { get; set; } = null!;

    public string Territory { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Code3 { get; set; } = null!;

    public string Number { get; set; } = null!;

    public string Iso { get; set; } = null!;

    public bool Deprecated { get; set; }

    public bool Active { get; set; }
}
