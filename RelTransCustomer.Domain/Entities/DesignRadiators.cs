using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignRadiators
{
    public string SpecNo { get; set; } = null!;

    public int? RevNo { get; set; }

    public int RadBankNo { get; set; }

    public int? NoOfPorts { get; set; }

    public int? TubeQty { get; set; }

    public double? TubeLength { get; set; }

    public double? FromFloor { get; set; }

    public double? Position { get; set; }

    public double? ToCorner { get; set; }

    public double? ToRim { get; set; }

    public int? Phases { get; set; }

    public double? Va { get; set; }

    public string? InsClass { get; set; }

    public double? VoltsClass { get; set; }

    public string? StandardRad { get; set; }

    public int? StandardRev { get; set; }

    public int? Rows { get; set; }

    public float? HeaderLength { get; set; }

    public string? RadType { get; set; }

    public float? Width { get; set; }

    public float? Height { get; set; }

    public float? Depth { get; set; }

    public float? BoxGauge { get; set; }

    public string? TubeType { get; set; }
}
