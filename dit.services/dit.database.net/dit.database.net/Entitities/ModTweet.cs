using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModTweet
{
    public uint TweetsId { get; set; }

    public string Account { get; set; } = null!;

    public string Config { get; set; } = null!;

    public string DescriptionNl { get; set; } = null!;
}
