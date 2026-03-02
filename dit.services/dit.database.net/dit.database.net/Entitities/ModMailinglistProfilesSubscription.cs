using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistProfilesSubscription
{
    public int Id { get; set; }

    public int ProfileId { get; set; }

    public int SubscriptionId { get; set; }
}
