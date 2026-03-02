using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubUserAuth
{
    public uint Id { get; set; }

    public string Email { get; set; } = null!;

    public string Token { get; set; } = null!;

    public DateTime Valid { get; set; }

    public string PushId { get; set; } = null!;

    public string Version { get; set; } = null!;

    public string Website { get; set; } = null!;

    public string DeviceId { get; set; } = null!;

    public string DeviceModel { get; set; } = null!;

    public string DevicePlatform { get; set; } = null!;

    public string DeviceVersion { get; set; } = null!;
}
