using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class TempRibs
{
    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public int RibNo { get; set; }

    public int? RibPos { get; set; }

    public string? RibPosName { get; set; }

    public double? RibQty { get; set; }

    public double? RibWidth { get; set; }

    public double? RibGuage { get; set; }

    public int? Phases { get; set; }

    public double? Va { get; set; }

    public string? InsClass { get; set; }

    public double? VoltsClass { get; set; }
}
