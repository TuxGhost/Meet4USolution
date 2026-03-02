using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModArticlesArticle
{
    public int ArticleId { get; set; }

    public int ArticlesId { get; set; }

    public DateTime PublishDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime EditDate { get; set; }

    public DateTime EventStart { get; set; }

    public DateTime EventEnd { get; set; }

    public string Author { get; set; } = null!;

    public int UserId { get; set; }

    public string Config { get; set; } = null!;

    public int Active { get; set; }

    public bool InIndex { get; set; }

    public bool IsIndex { get; set; }

    public int SortOrder { get; set; }

    public int Views { get; set; }

    public int Clicks { get; set; }

    public string VideoLink { get; set; } = null!;

    public int VideoWidth { get; set; }

    public int VideoHeight { get; set; }

    public string? Image { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime LastModified { get; set; }

    public string TitleNl { get; set; } = null!;

    public string HighlightNl { get; set; } = null!;

    public string IntroNl { get; set; } = null!;

    public string BodyNl { get; set; } = null!;

    public string KeywordsNl { get; set; } = null!;

    public string LinkNl { get; set; } = null!;

    public string? AliasNl { get; set; }

    public bool? VisibleNl { get; set; }

    public string TitleDe { get; set; } = null!;

    public string HighlightDe { get; set; } = null!;

    public string IntroDe { get; set; } = null!;

    public string BodyDe { get; set; } = null!;

    public string KeywordsDe { get; set; } = null!;

    public string LinkDe { get; set; } = null!;

    public string AliasDe { get; set; } = null!;

    public bool? VisibleDe { get; set; }

    public string TitleEn { get; set; } = null!;

    public string HighlightEn { get; set; } = null!;

    public string IntroEn { get; set; } = null!;

    public string BodyEn { get; set; } = null!;

    public string KeywordsEn { get; set; } = null!;

    public string LinkEn { get; set; } = null!;

    public string AliasEn { get; set; } = null!;

    public bool? VisibleEn { get; set; }

    public string TitleFr { get; set; } = null!;

    public string HighlightFr { get; set; } = null!;

    public string IntroFr { get; set; } = null!;

    public string BodyFr { get; set; } = null!;

    public string KeywordsFr { get; set; } = null!;

    public string LinkFr { get; set; } = null!;

    public string AliasFr { get; set; } = null!;

    public bool? VisibleFr { get; set; }

    public string TitleBe { get; set; } = null!;

    public string HighlightBe { get; set; } = null!;

    public string IntroBe { get; set; } = null!;

    public string BodyBe { get; set; } = null!;

    public string KeywordsBe { get; set; } = null!;

    public string LinkBe { get; set; } = null!;

    public string AliasBe { get; set; } = null!;

    public bool? VisibleBe { get; set; }
}
