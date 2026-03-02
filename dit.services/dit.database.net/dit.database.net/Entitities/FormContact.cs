using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class FormContact
{
    public int ContactId { get; set; }

    public string? Title { get; set; }

    public string? Firstname { get; set; }

    public string? Infix { get; set; }

    public string? Lastname { get; set; }

    public string? Street { get; set; }

    public string? Housenumber { get; set; }

    public string? Addition { get; set; }

    public string? Zipcode { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Telephone { get; set; }

    public string? Email { get; set; }

    public string Comment { get; set; } = null!;

    public string JouwBericht { get; set; } = null!;

    public string? CountryId { get; set; }

    public string? Recaptcha { get; set; }
}
