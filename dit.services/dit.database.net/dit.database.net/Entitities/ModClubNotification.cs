using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubNotification
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string Data { get; set; } = null!;

    public bool Sent { get; set; }

    public bool Opened { get; set; }

    public DateTime DateCreated { get; set; }
}
