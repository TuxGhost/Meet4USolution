using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Statistic
{
    public int Id { get; set; }

    public string Siteid { get; set; } = null!;

    public string? Ip { get; set; }

    public DateTime Date { get; set; }

    public DateTime DateLast { get; set; }

    public string? Referer { get; set; }

    public string? Os { get; set; }

    public string? Browser { get; set; }

    public string? Country { get; set; }

    public int Countnumber { get; set; }
}
