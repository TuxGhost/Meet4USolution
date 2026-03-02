using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class SocialCache
{
    public string Network { get; set; } = null!;

    public int UserId { get; set; }

    public DateTime Date { get; set; }

    public string Message { get; set; } = null!;
}
