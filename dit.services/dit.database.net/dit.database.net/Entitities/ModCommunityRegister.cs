using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModCommunityRegister
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string Email { get; set; } = null!;
}
