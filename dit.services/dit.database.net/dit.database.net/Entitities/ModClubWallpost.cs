using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModClubWallpost
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public uint? AgegroupId { get; set; }

    public int EventDateId { get; set; }

    public string Type { get; set; } = null!;

    public int ExtraId { get; set; }

    public string Text { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public virtual ModClubAgegroup? Agegroup { get; set; }

    public virtual ICollection<ModClubWallpostComment> ModClubWallpostComments { get; set; } = new List<ModClubWallpostComment>();

    public virtual ICollection<ModClubWallpostImage> ModClubWallpostImages { get; set; } = new List<ModClubWallpostImage>();

    public virtual ICollection<ModClubAgegroup> Agegroups { get; set; } = new List<ModClubAgegroup>();
}
