using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModArticlesVote
{
    public uint VoteId { get; set; }

    public uint ArticleId { get; set; }

    public DateTime Date { get; set; }

    public int Ip { get; set; }

    public int Vote { get; set; }
}
