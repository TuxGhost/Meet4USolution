using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistEasymail
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Senderemail { get; set; } = null!;

    public string Sendername { get; set; } = null!;

    public int TemplateId { get; set; }

    public DateTime Modified { get; set; }

    public string TitleNl { get; set; } = null!;

    public string TitleDe { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string SubTitle { get; set; } = null!;

    public string Text1Nl { get; set; } = null!;

    public string Text2Nl { get; set; } = null!;

    public string Text3Nl { get; set; } = null!;

    public string Text1De { get; set; } = null!;

    public string Text2De { get; set; } = null!;

    public string Text3De { get; set; } = null!;

    public string Text1En { get; set; } = null!;

    public string Text2En { get; set; } = null!;

    public string Text3En { get; set; } = null!;

    public string Product { get; set; } = null!;

    public string Pricelist { get; set; } = null!;

    public short ImageWidth { get; set; }
}
