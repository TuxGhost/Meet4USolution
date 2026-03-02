using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistSaved
{
    public int Id { get; set; }

    public int MailinglistId { get; set; }

    public string? Title { get; set; }

    public bool AutoSave { get; set; }

    public string? Userid { get; set; }

    public DateTime? Edited { get; set; }

    public string SenderEmail { get; set; } = null!;

    public string SenderName { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string SendTo { get; set; } = null!;

    public string FontFamily { get; set; } = null!;

    public string Testaddress { get; set; } = null!;

    public string? Body { get; set; }

    public bool MailingType { get; set; }
}
