using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubEventComment
{
    public uint Id { get; set; }

    public uint? EventDateId { get; set; }

    public uint UserId { get; set; }

    public string Text { get; set; } = null!;

    public bool FromApp { get; set; }

    public bool Active { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }
}
