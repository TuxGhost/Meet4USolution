using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class FormTestForm
{
    public int TestFormId { get; set; }

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

    public string? Test { get; set; }

    public string? Pdf { get; set; }
}
