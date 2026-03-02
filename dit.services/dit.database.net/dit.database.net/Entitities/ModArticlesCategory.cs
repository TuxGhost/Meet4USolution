using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModArticlesCategory
{
    public uint CategoryId { get; set; }

    public int ArticlesId { get; set; }

    public uint CategoryParentId { get; set; }

    public string? CategoryReference { get; set; }

    public bool CategoryActive { get; set; }

    public uint CategorySortOrder { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? LastModified { get; set; }

    public string? NameNl { get; set; }

    public string AliasNl { get; set; } = null!;

    public bool? VisibleNl { get; set; }

    public string NameDe { get; set; } = null!;

    public string AliasDe { get; set; } = null!;

    public bool? VisibleDe { get; set; }

    public string NameEn { get; set; } = null!;

    public string AliasEn { get; set; } = null!;

    public bool? VisibleEn { get; set; }

    public string NameFr { get; set; } = null!;

    public string AliasFr { get; set; } = null!;

    public bool? VisibleFr { get; set; }

    public string NameBe { get; set; } = null!;

    public string AliasBe { get; set; } = null!;

    public bool? VisibleBe { get; set; }
}
