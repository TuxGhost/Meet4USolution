using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Iva
{
    public ulong Id { get; set; }

    public string Reference { get; set; } = null!;

    public DateTime Date { get; set; }

    public ushort Period { get; set; }

    public int Year { get; set; }

    public string Type { get; set; } = null!;

    public string Dc { get; set; } = null!;

    public string Account { get; set; } = null!;

    public string AccountRef { get; set; } = null!;

    public string OwnReference { get; set; } = null!;

    public string Debcred { get; set; } = null!;

    public string DebcredName { get; set; } = null!;

    public decimal Excl { get; set; }

    public decimal Incl { get; set; }

    public ulong OrderId { get; set; }

    public string Invoice { get; set; } = null!;

    public DateTime InvoiceDate { get; set; }

    public string InvoiceDocument { get; set; } = null!;

    public bool Importexport { get; set; }

    public int CompanyId { get; set; }

    public string VatNumber { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string CountryId { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string BankAccount { get; set; } = null!;

    public DateTime PayBeforeDate { get; set; }

    public DateTime DatePaid { get; set; }

    public bool Paid { get; set; }

    public string Comments { get; set; } = null!;
}
