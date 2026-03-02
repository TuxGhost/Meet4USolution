using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistArchive
{
    public int Id { get; set; }

    public int MailinglistId { get; set; }

    public string SenderEmail { get; set; } = null!;

    public string SenderName { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string SendTo { get; set; } = null!;

    public bool? Email { get; set; }

    public DateTime Sendtime { get; set; }

    public string Body { get; set; } = null!;

    public int Sended { get; set; }

    public int Receivers { get; set; }

    public short MailingType { get; set; }

    public string Document { get; set; } = null!;
}
