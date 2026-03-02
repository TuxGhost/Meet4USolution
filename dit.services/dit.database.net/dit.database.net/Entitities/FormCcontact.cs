using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class FormCcontact
{
    public int CcontactId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Zipcode { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Telephone { get; set; }

    public string? Email { get; set; }

    public string Comment { get; set; } = null!;
}
