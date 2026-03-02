using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Owner
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string CountryId { get; set; } = null!;

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public string Telephone { get; set; } = null!;

    public string? Fax { get; set; }

    public string Email { get; set; } = null!;

    public string VatNumber { get; set; } = null!;

    public string CocNumber { get; set; } = null!;

    public string BankAccount { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string BankIban { get; set; } = null!;

    public string BankBic { get; set; } = null!;

    public string BankDetails { get; set; } = null!;

    public string Logo { get; set; } = null!;

    public string Logo2 { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime LastModified { get; set; }

    public string FooterInvoice { get; set; } = null!;

    public string FooterOrder { get; set; } = null!;

    public string FooterShipping { get; set; } = null!;
}
