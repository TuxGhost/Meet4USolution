using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModArticlesArticleRevision
{
    public int RevisionId { get; set; }

    public int ArticleId { get; set; }

    public int Revision { get; set; }

    public DateTime CreationDate { get; set; }

    public string Author { get; set; } = null!;

    public int UserId { get; set; }

    public string TitleNl { get; set; } = null!;

    public string HighlightNl { get; set; } = null!;

    public string IntroNl { get; set; } = null!;

    public string BodyNl { get; set; } = null!;

    public string KeywordsNl { get; set; } = null!;

    public string? AliasNl { get; set; }

    public string Version { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public string TitleDe { get; set; } = null!;

    public string HighlightDe { get; set; } = null!;

    public string IntroDe { get; set; } = null!;

    public string BodyDe { get; set; } = null!;

    public string KeywordsDe { get; set; } = null!;

    public string AliasDe { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string HighlightEn { get; set; } = null!;

    public string IntroEn { get; set; } = null!;

    public string BodyEn { get; set; } = null!;

    public string KeywordsEn { get; set; } = null!;

    public string AliasEn { get; set; } = null!;

    public string TitleFr { get; set; } = null!;

    public string HighlightFr { get; set; } = null!;

    public string IntroFr { get; set; } = null!;

    public string BodyFr { get; set; } = null!;

    public string KeywordsFr { get; set; } = null!;

    public string AliasFr { get; set; } = null!;

    public string TitleBe { get; set; } = null!;

    public string HighlightBe { get; set; } = null!;

    public string IntroBe { get; set; } = null!;

    public string BodyBe { get; set; } = null!;

    public string KeywordsBe { get; set; } = null!;

    public string AliasBe { get; set; } = null!;
}
