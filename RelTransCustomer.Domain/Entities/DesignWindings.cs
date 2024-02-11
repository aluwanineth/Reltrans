using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignWindings
{
    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public string PriSec { get; set; } = null!;

    public int WindingNo { get; set; }

    public int? TapCount { get; set; }

    public int? Phases { get; set; }

    public double? Va { get; set; }

    public string? InsClass { get; set; }

    public double? VoltsClass { get; set; }

    public int? Reps { get; set; }
}
