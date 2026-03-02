using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModBannerStat
{
    public int BannerId { get; set; }

    public int BannerImageId { get; set; }

    public DateTime Date { get; set; }

    public int Views { get; set; }

    public int Clicks { get; set; }
}
