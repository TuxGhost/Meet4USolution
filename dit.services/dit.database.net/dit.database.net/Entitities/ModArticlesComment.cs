using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModArticlesComment
{
    public int CommentId { get; set; }

    public int ArticleId { get; set; }

    public int ArticlesId { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public DateTime Date { get; set; }

    public int Ip { get; set; }
}
