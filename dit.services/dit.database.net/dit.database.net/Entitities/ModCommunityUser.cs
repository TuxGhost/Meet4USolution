using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModCommunityUser
{
    public string Email { get; set; } = null!;

    public string? Gender { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public int? Address { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? Newsletter { get; set; }

    public int? Signupformid { get; set; }

    public int? Signupid { get; set; }
}
