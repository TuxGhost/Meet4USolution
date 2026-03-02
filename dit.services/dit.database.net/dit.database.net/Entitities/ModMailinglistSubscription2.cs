using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistSubscription2
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Initials { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Email { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Housenumber { get; set; } = null!;

    public string City { get; set; } = null!;

    public string CountryId { get; set; } = null!;

    public int MailinglistId { get; set; }

    public string SubscriptionLanguage { get; set; } = null!;

    public int Signupform { get; set; }

    public int Signupformid { get; set; }

    public int ShopUserId { get; set; }

    public string? Register { get; set; }

    public bool SubEmail { get; set; }

    public bool SubMail { get; set; }

    public bool Dirty { get; set; }
}
