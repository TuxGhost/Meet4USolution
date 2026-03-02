using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModForumPost
{
    public int PostId { get; set; }

    public int ReplyOn { get; set; }

    public int ForumId { get; set; }

    public int PosterId { get; set; }

    public string Subject { get; set; } = null!;

    public DateTime Postdate { get; set; }

    public string Post { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public int TimesViewed { get; set; }

    public DateTime LastView { get; set; }

    public DateTime LastEdit { get; set; }

    public int EditedBy { get; set; }

    public int Status { get; set; }
}
