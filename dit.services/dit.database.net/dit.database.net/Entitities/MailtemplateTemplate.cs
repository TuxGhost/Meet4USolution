using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class MailtemplateTemplate
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Content { get; set; }

    public string? Css { get; set; }

    public string? Language { get; set; }

    public string? Subject { get; set; }

    public int TemplateId { get; set; }

    public string? Adminemail { get; set; }

    public string Adminname { get; set; } = null!;

    public string Senderemail { get; set; } = null!;

    public string Sendername { get; set; } = null!;

    public string Replytoemail { get; set; } = null!;

    public string Replytoname { get; set; } = null!;

    public string Alternativebody { get; set; } = null!;

    public string? Attachment { get; set; }
}
