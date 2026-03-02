using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModForm
{
    public int FormId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Resultpage { get; set; } = null!;

    public string Css { get; set; } = null!;

    public int ConfirmationmailCustomer { get; set; }

    public int ConfirmationmailAdmin { get; set; }

    public string Width { get; set; } = null!;

    public int InDatabase { get; set; }

    public int ShowConfirmationpage { get; set; }

    public int StandardCommunity { get; set; }

    public int StandardMailinglist { get; set; }

    public int InMailinglist { get; set; }

    public string TitleDe { get; set; } = null!;

    public string IntrotextDe { get; set; } = null!;

    public string ConfirmtextDe { get; set; } = null!;

    public string ResulttextDe { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string IntrotextEn { get; set; } = null!;

    public string ConfirmtextEn { get; set; } = null!;

    public string ResulttextEn { get; set; } = null!;

    public string TitleNl { get; set; } = null!;

    public string IntrotextNl { get; set; } = null!;

    public string ConfirmtextNl { get; set; } = null!;

    public string ResulttextNl { get; set; } = null!;

    public string TitleFr { get; set; } = null!;

    public string IntrotextFr { get; set; } = null!;

    public string ConfirmtextFr { get; set; } = null!;

    public string ResulttextFr { get; set; } = null!;

    public string TitleBe { get; set; } = null!;

    public string IntrotextBe { get; set; } = null!;

    public string ConfirmtextBe { get; set; } = null!;

    public string ResulttextBe { get; set; } = null!;
}
