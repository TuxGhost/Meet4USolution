using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistProfile
{
    public int Id { get; set; }

    public int MailinglistId { get; set; }

    public string Name { get; set; } = null!;

    public short ExternId { get; set; }

    public bool? Custom { get; set; }
}
