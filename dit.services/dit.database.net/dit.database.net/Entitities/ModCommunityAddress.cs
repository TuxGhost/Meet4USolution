using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModCommunityAddress
{
    public int Id { get; set; }

    public string? Street { get; set; }

    public string? Zipcode { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Companyname { get; set; }

    public string? Homepage { get; set; }

    public string? ZoneId { get; set; }

    public string Suburb { get; set; } = null!;
}
