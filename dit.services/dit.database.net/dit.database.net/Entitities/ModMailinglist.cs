using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglist
{
    public int Id { get; set; }

    public int Mailinglistserver { get; set; }

    public int Periodic { get; set; }

    public int PeriodInterval { get; set; }

    public int PeriodDate { get; set; }

    public int DefaultTemplate { get; set; }

    public string DefaultSubject { get; set; } = null!;

    public string DefaultSendfrom { get; set; } = null!;

    public string DefaultSendfromName { get; set; } = null!;

    public int DefaultSendto { get; set; }

    public string DefaultTestaddress { get; set; } = null!;

    public int? Signupform { get; set; }

    public int? Communitygroup { get; set; }

    public string? Name { get; set; }

    public int Signupmoduleid { get; set; }
}
