using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistMailOption
{
    public int Id { get; set; }

    public int DefaultTemplate { get; set; }

    public string DefaultSendfromName { get; set; } = null!;

    public int DefaultSendto { get; set; }

    public string DefaultFontFamily { get; set; } = null!;
}
