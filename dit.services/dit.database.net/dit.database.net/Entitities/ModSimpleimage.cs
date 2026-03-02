using System;
using System.Collections.Generic;

namespace dit.database.net.Entitities;

public partial class ModSimpleimage
{
    public uint Id { get; set; }

    public int Moduleid { get; set; }

    public string View { get; set; } = null!;

    public string ViewType { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool DescriptionVisible { get; set; }

    public bool Resize { get; set; }

    public bool Transparency { get; set; }

    public bool Original { get; set; }

    public int OriginalHeight { get; set; }

    public int OriginalWidth { get; set; }

    public bool Thumb { get; set; }

    public int ThumbHeight { get; set; }

    public int ThumbWidth { get; set; }

    public bool Icon { get; set; }

    public int IconHeight { get; set; }

    public int IconWidth { get; set; }

    public bool Big { get; set; }

    public int BigHeight { get; set; }

    public int BigWidth { get; set; }

    public string Variables { get; set; } = null!;

    public bool RandomSort { get; set; }
}
