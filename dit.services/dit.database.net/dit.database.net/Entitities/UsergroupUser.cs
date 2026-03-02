using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class UsergroupUser
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public int Groupid { get; set; }

    public int Admin { get; set; }
}
