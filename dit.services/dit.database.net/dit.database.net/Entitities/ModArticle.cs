using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModArticle
{
    public uint ArticlesId { get; set; }

    public int ShowTitle { get; set; }

    public uint UsesDataFrom { get; set; }

    public int TargetPage { get; set; }

    public string View { get; set; } = null!;

    public string DetailView { get; set; } = null!;

    public string InstanceConfig { get; set; } = null!;

    public string ListConfig { get; set; } = null!;

    public string DetailConfig { get; set; } = null!;

    public string SortOn { get; set; } = null!;

    public string SortOrder { get; set; } = null!;

    public int CommentChars { get; set; }

    public int Limiter { get; set; }

    public int RssEnabled { get; set; }

    public string RssSortOn { get; set; } = null!;

    public string RssSortOrder { get; set; } = null!;

    public int RssLimiter { get; set; }

    public string RssKey { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime LastModified { get; set; }

    public string TitleNl { get; set; } = null!;

    public string AliasNl { get; set; } = null!;

    public string TitleDe { get; set; } = null!;

    public string AliasDe { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string AliasEn { get; set; } = null!;

    public string TitleFr { get; set; } = null!;

    public string AliasFr { get; set; } = null!;

    public string TitleBe { get; set; } = null!;

    public string AliasBe { get; set; } = null!;
}
