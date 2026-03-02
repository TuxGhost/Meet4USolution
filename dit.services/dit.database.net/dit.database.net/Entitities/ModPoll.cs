using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModPoll
{
    public int PollId { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public int Active { get; set; }

    public int VoteTime { get; set; }
}
