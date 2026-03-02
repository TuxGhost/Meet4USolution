using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModFormField
{
    public int FieldId { get; set; }

    public int FormId { get; set; }

    public string Height { get; set; } = null!;

    public string Width { get; set; } = null!;

    public int MaxInput { get; set; }

    public string CssId { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Subtype { get; set; } = null!;

    public int Partof { get; set; }

    public string Name { get; set; } = null!;

    public string SubscriptionName { get; set; } = null!;

    public string Action { get; set; } = null!;

    public int Multiple { get; set; }

    public int Password { get; set; }

    public int Active { get; set; }

    public int Sort { get; set; }

    public int Obligated { get; set; }

    public string ValidationType { get; set; } = null!;

    public string Related { get; set; } = null!;

    public int InMailCustomer { get; set; }

    public int InMailAdmin { get; set; }

    public int InAdminList { get; set; }

    public string StandardFieldcode { get; set; } = null!;

    public int Short { get; set; }

    public string LabelDe { get; set; } = null!;

    public string GrouplabelDe { get; set; } = null!;

    public string LabelEn { get; set; } = null!;

    public string GrouplabelEn { get; set; } = null!;

    public string LabelNl { get; set; } = null!;

    public string GrouplabelNl { get; set; } = null!;

    public string LabelFr { get; set; } = null!;

    public string GrouplabelFr { get; set; } = null!;

    public string LabelBe { get; set; } = null!;

    public string GrouplabelBe { get; set; } = null!;
}
