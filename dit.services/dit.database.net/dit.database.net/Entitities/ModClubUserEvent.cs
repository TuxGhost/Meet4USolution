using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubUserEvent
{
    public uint UserId { get; set; }

    public uint EventDateId { get; set; }

    public DateTime AttendDate { get; set; }

    public bool UnsubscribePending { get; set; }

    public virtual ModClubEventDate EventDate { get; set; } = null!;
}
