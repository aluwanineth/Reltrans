using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class ProjectInUse
{
    public string SpecNo { get; set; } = null!;

    public string UsedBy { get; set; } = null!;

    public DateTime Date { get; set; }
}
