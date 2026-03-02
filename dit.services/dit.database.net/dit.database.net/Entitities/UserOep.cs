using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class UserOep
{
    public uint Id { get; set; }

    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Language { get; set; } = null!;

    public bool Status { get; set; }

    public string Activate { get; set; } = null!;

    public int Js { get; set; }

    public string UserId { get; set; } = null!;

    public string PreferedWebsite { get; set; } = null!;

    public bool System { get; set; }

    public bool Super { get; set; }

    public string Avatar { get; set; } = null!;

    public string JmlPassword { get; set; } = null!;

    public string PasswordResetKey { get; set; } = null!;
}
