using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModPollVoter
{
    public int VoterId { get; set; }

    public int PollId { get; set; }

    public string Ip { get; set; } = null!;

    public string TimeLastVoted { get; set; } = null!;
}
