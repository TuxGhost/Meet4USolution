using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace dit.database.net.Entitities;

public partial class ModClubUser
{
    public uint Id { get; set; }

    public string Email { get; set; } = null!;

    public int MemberNumber { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Gender { get; set; } = null!;    
    public DateTime Dob { get; set; }

    public string Address { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    /// <summary>
    /// Telefoon
    /// </summary>
    public string Telephone { get; set; } = null!;

    /// <summary>
    /// GSM
    /// </summary>
    public string Telephone2 { get; set; } = null!;

    /// <summary>
    /// 0: Aspirant, 1: Lid, 2: Oud Lid
    /// </summary>
    public string Type { get; set; } = null!;

    public bool InfoAvond { get; set; }

    /// <summary>
    /// Bestuurslid
    /// </summary>
    public bool BoardMember { get; set; }

    public string BoardType { get; set; } = null!;

    /// <summary>
    /// Functie beschrijving
    /// </summary>
    public string BoardFunction { get; set; } = null!;

    public bool Blocked { get; set; }

    public bool Active { get; set; }

    public string Comments { get; set; } = null!;

    public string CommentsIntern { get; set; } = null!;

    public string Referrer { get; set; } = null!;

    public string ReferrerExtra { get; set; } = null!;

    public bool? AgreeList { get; set; }

    public bool? AgreeData20Years { get; set; }

    public bool? CanPostOnWall { get; set; }

    public int MailinglistSubId { get; set; }

    public int EventManagementLevel { get; set; }    
    public DateTime DateCreated { get; set; }    
    public DateTime DateModified { get; set; }

    public virtual ICollection<ModClubTransaction> ModClubTransactions { get; set; } = new List<ModClubTransaction>();

    public virtual ICollection<ModClubUserSubscription> ModClubUserSubscriptions { get; set; } = new List<ModClubUserSubscription>();
}
