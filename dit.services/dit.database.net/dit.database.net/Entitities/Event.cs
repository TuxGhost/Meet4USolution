using System;
using System.Collections.Generic;

namespace dit.database.net;

public partial class Event
{
    public long Id { get; set; }

    public short Cid { get; set; }

    public string Title { get; set; } = null!;

    public DateTime Start { get; set; }

    public DateTime End { get; set; }

    public string Loc { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool Ad { get; set; }

    public string Rem { get; set; } = null!;
}
