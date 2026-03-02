using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Manufacturer
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Housenumber { get; set; } = null!;

    public string City { get; set; } = null!;

    public string CountryId { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Website { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Telephone2 { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime LastModified { get; set; }

    public string Image { get; set; } = null!;

    /// <summary>
    /// array::html::#languages#::description
    /// </summary>
    public string? DescriptionEn { get; set; }

    /// <summary>
    /// array::string::#languages#::alias
    /// </summary>
    public string AliasEn { get; set; } = null!;
}
