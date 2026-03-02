using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModBannerImage
{
    public int Id { get; set; }

    public int BannerId { get; set; }

    public string Photo { get; set; } = null!;

    public int Sort { get; set; }

    public bool Visible { get; set; }

    public string Company { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string Vat { get; set; } = null!;

    public string Url { get; set; } = null!;

    public DateTime PublishDate { get; set; }

    public DateTime EndDate { get; set; }
}
