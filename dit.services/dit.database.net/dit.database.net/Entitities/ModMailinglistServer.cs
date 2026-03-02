using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModMailinglistServer
{
    public int Id { get; set; }

    public int MailinglistId { get; set; }

    public string Name { get; set; } = null!;

    public string Emailaddress { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Subscribe { get; set; } = null!;

    public string Unsubscribe { get; set; } = null!;
}
