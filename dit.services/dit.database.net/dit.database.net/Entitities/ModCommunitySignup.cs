using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModCommunitySignup
{
    public int SignupId { get; set; }

    public string TypeActivation { get; set; } = null!;

    public string Adminmail { get; set; } = null!;

    public int Template { get; set; }

    public string Usergroups { get; set; } = null!;

    public int? Signupform { get; set; }
}
