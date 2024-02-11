using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class TempWire
{
    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public string PriSec { get; set; } = null!;

    public int WindingNo { get; set; }

    public int TapNo { get; set; }

    public int StrandNo { get; set; }

    public double? WireWidth { get; set; }

    public double? WireHeight { get; set; }

    public int? WireIdno { get; set; }

    public double? WireInsX { get; set; }

    public double? WireInsY { get; set; }
}
