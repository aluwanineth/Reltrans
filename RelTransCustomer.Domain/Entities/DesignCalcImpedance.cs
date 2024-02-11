using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignCalcImpedance
{
    public int RecId { get; set; }

    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public int? Side { get; set; }

    public int? Wind { get; set; }

    public float? Turns { get; set; }

    public float? WireBare { get; set; }

    public float? Od1 { get; set; }

    public float? Od2 { get; set; }

    public float? Od1total { get; set; }

    public float? Od2total { get; set; }

    public float? Wlength { get; set; }

    public float? EdgeStrips { get; set; }

    public float? EdgeStrips2 { get; set; }

    public float? Mlt { get; set; }

    public float? Radial1 { get; set; }

    public float? Radial2 { get; set; }
}
