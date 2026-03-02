using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class Social
{
    public sbyte Id { get; set; }

    public int UserId { get; set; }

    public string? Type { get; set; }

    public string Name { get; set; } = null!;

    public string? AccessToken { get; set; }

    public string? Secret { get; set; }

    public bool? Active { get; set; }

    public bool ActiveWebsite { get; set; }

    public string AccountName { get; set; } = null!;

    public string AccountId { get; set; } = null!;
}
