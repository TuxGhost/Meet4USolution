using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistProfilingSubscription
{
    public int Id { get; set; }

    public int SubscriptionId { get; set; }

    public string Hash { get; set; } = null!;
}
