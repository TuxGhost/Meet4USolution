using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubEventDate
{
    public uint Id { get; set; }

    public uint EventId { get; set; }

    public DateTime Start { get; set; }

    public DateTime End { get; set; }

    public DateTime AttendTill { get; set; }

    public DateTime? CancelledOn { get; set; }

    public virtual ModClubEvent Event { get; set; } = null!;

    public virtual ICollection<ModClubUserEvent> ModClubUserEvents { get; set; } = new List<ModClubUserEvent>();
}
