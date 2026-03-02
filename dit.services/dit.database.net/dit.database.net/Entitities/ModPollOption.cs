using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModPollOption
{
    public int OptionId { get; set; }

    public int PollId { get; set; }

    public int Sort { get; set; }

    public int Count { get; set; }
}
