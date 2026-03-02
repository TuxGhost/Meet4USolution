using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dit.database.net.Entitities;

public partial class ModClubEvent
{
    public uint Id { get; set; }

    public uint? Creator { get; set; }

    public bool PaidEvent { get; set; }

    public bool PayAfter { get; set; }

    public decimal Price { get; set; }

    public bool ChildSafe { get; set; }

    public bool WheelchairSafe { get; set; }

    public bool Priority { get; set; }

    public bool? BoardMemberEvent { get; set; }

    public DateTime? EventStart { get; set; }

    public DateTime? EventEnd { get; set; }

    public string EventRepeat { get; set; } = null!;

    public DateTime EventTill { get; set; }

    public DateTime AttendTill { get; set; }

    public bool AttendRepeat { get; set; }

    public string Address { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public string City { get; set; } = null!;
    [MinLength(2), MaxLength(2)]
    public string Country { get; set; } = null!;

    public decimal Lat { get; set; }

    public decimal Lng { get; set; }

    public bool Active { get; set; }

    public string Image { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public int OldId { get; set; }

    public string NameNl { get; set; } = null!;

    public string DescriptionNl { get; set; } = null!;

    public string AliasNl { get; set; } = null!;

    public virtual ICollection<ModClubEventDate> ModClubEventDates { get; set; } = new List<ModClubEventDate>();

    public virtual ICollection<ModClubEventImage> ModClubEventImages { get; set; } = new List<ModClubEventImage>();

    public virtual ICollection<ModClubEventMembertype> ModClubEventMembertypes { get; set; } = new List<ModClubEventMembertype>();

    public virtual ICollection<ModClubEventOrganisator> ModClubEventOrganisators { get; set; } = new List<ModClubEventOrganisator>();

    public virtual ICollection<ModClubAgegroup> Agegroups { get; set; } = new List<ModClubAgegroup>();

    public virtual ICollection<ModClubTag> Tags { get; set; } = new List<ModClubTag>();
}
