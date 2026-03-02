using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModPollClubVoter
{
    public int Id { get; set; }

    public int PollId { get; set; }

    public int ClubUserId { get; set; }

    public string TimeLastVoted { get; set; } = null!;
}
