using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModForumUser
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string Avatar { get; set; } = null!;

    public int UseAvatar { get; set; }

    public string Signature { get; set; } = null!;

    public int UseSignature { get; set; }
}
