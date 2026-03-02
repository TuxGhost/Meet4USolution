using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModForum
{
    public int ForumId { get; set; }

    public string Title { get; set; } = null!;

    public int ShowTitle { get; set; }

    public int TopicsPerPage { get; set; }

    public int PostsPerPage { get; set; }

    public int AllowSmilies { get; set; }

    public int AllowHtml { get; set; }

    public int AllowBbcode { get; set; }

    public int AllowAvatars { get; set; }

    public int AllowSignature { get; set; }

    public string Css { get; set; } = null!;

    public int Ipblockinstance { get; set; }

    public int Badwordinstance { get; set; }

    public int Registrationpage { get; set; }
}
